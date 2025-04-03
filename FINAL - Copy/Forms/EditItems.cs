using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final.AddItem;

namespace Final.Forms
{
    public partial class EditItems : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        string imagePath = "";
        string currentUser = "";
        public event EventHandler<ItemUpdatedEventArgs> ItemUpdated;
        public bool WasUpdated { get; private set; } = false;
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Image ItemImage { get; set; }
        public string FeedType { get; set; }
        public string Status { get; set; }
        public EditItems(string itemName, int quantity, decimal price, Image itemImage, string feedType, string status)
        {
            InitializeComponent();
            // Set the properties
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
            ItemImage = itemImage;
            FeedType = feedType;
            Status = status;

            // Display the data in the form controls
            tbxItemName.Text = ItemName;
            tbxStock.Text = Quantity.ToString();
            tbxPrice.Text = Price.ToString("N2");
            imgView.Image = ItemImage;
            cbxType.SelectedItem = FeedType;
            cbxStatus.SelectedItem = Status;
            currentUser = lblID.Text;
        }
        public class ItemUpdatedEventArgs : EventArgs
        {
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public string FeedType { get; set; }
            public string Status { get; set; }
            public Image Image { get; set; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgView_Click(object sender, EventArgs e)
        {

        }

        private void btnImportPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    imgView.ImageLocation = imagePath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxItemName.Text))
            {
                MessageBox.Show("Please enter an item name");
                return;
            }

            if (!int.TryParse(tbxStock.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity (whole number)");
                return;
            }

            if (!decimal.TryParse(tbxPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price (numeric value)");
                return;
            }

            if (cbxType.SelectedItem == null || cbxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select both feed type and status");
                return;
            }
            byte[] imageBytes = null;
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    Image img = Image.FromFile(imagePath);
                    imageBytes = ImageToOleDbByteArray(img);
                }
                catch
                {
                    // Silently continue without updating the image
                }
            }
            else if (imgView.Image != null)
            {
                // Use the existing image if no new image was selected
                imageBytes = ImageToOleDbByteArray(imgView.Image);
            }
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");
            da = new OleDbDataAdapter("SELECT *FROM Account", myConn);

            // Proceed with database update if all validations pass
            using (var myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb"))
            {
                string query = "UPDATE Inventory SET [Item] = @itemname, [Quantity] = @quantity, [Price] = @price, " +
                      "[FeedType] = @feedtype, [Status] = @status" +
                      (imageBytes != null ? ", [Image] = @image" : "") +
                      " WHERE [Item] = @originalItemName";


                using (var cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@itemname", tbxItemName.Text);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@feedtype", cbxType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@status", cbxStatus.SelectedItem.ToString());
                    //    cmd.Parameters.Add("@image", OleDbType.VarBinary).Value = imgBytes;
                    //    cmd.Parameters.AddWithValue("@id", currentUser);
                    if (imageBytes != null)
                    {
                        cmd.Parameters.Add("@image", OleDbType.VarBinary).Value = imageBytes;
                    }

                    cmd.Parameters.AddWithValue("@originalItemName", ItemName); // Using the original item name as identifier
                    try
                    {
                        myConn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            WasUpdated = true; // Set this flag to true
                            MessageBox.Show("Item updated successfully!");
                            ItemUpdated?.Invoke(this, new ItemUpdatedEventArgs
                            {
                                ItemName = tbxItemName.Text,
                                Quantity = Convert.ToInt32(tbxStock.Text),
                                Price = Convert.ToDecimal(tbxPrice.Text),
                                FeedType = cbxType.SelectedItem?.ToString(),
                                Status = cbxStatus.SelectedItem?.ToString(),
                                Image = imgView.Image
                            });
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Item may not exist.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating record: " + ex.Message);
                    }

                }
               
            }

        }
        private byte[] ImageToOleDbByteArray(Image img)
        {
            if (img == null)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Save as BMP (OLE Object in Access typically expects BMP format)
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    return ms.ToArray();
                }
            }
            catch
            {
                return null; // Silently fail if conversion fails
            }
        }
    }
}
