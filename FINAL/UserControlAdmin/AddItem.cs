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

namespace Final
{
    public partial class AddItem : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public event EventHandler<ItemAddedEventArgs> ItemAdded;

        public AddItem()
        {
            InitializeComponent();
        }
        public class ItemAddedEventArgs : EventArgs
        {
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public string FeedType { get; set; }
            public string Status { get; set; }
            public Image Image { get; set; }
        }
        public void SetItemValues(string name, string quantity, string price, string feedType, string status, Image image)
        {
            tbxItemName.Text = name;
            tbxStock.Text = quantity;
            tbxPrice.Text = price;
            cbxType.SelectedItem = feedType;
            cbxStatus.SelectedItem = status;
            imgView.Image = image;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");
            da = new OleDbDataAdapter("SELECT *FROM Inventory", myConn);
            string query = "Insert into Inventory ([Item], [Quantity], [Price], [FeedType], [Status], [Image]) values (@itemname, @quantity, @price, @feedtype, @status, @image)";
            myConn.Open();
            if (tbxItemName.Text == string.Empty || tbxStock.Text == string.Empty || tbxPrice.Text == string.Empty)
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxType.SelectedItem == null)
            {
                MessageBox.Show("Please select Feed Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select the Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (imgView.Image == null)
            {
                MessageBox.Show("Please select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@itemname", tbxItemName.Text);
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(tbxStock.Text));
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(tbxPrice.Text));
            cmd.Parameters.AddWithValue("@feedtype", cbxType.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@status", cbxStatus.SelectedItem.ToString());
            //conerting img to byte array
            MemoryStream ms = new MemoryStream();
            imgView.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imageBytes = ms.ToArray();
            //img as parameter
            cmd.Parameters.AddWithValue("@image", imageBytes);
            cmd.ExecuteNonQuery();
            myConn.Close();
            ItemAdded?.Invoke(this, new ItemAddedEventArgs
            {
                ItemName = tbxItemName.Text,
                Quantity = Convert.ToInt32(tbxStock.Text),
                Price = Convert.ToDecimal(tbxPrice.Text),
                FeedType = cbxType.SelectedItem?.ToString(),
                Status = cbxStatus.SelectedItem?.ToString(),
                Image = imgView.Image
            });
            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Parent.Controls.Remove(this);
        }

        private void btnImportPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files(*.png)|*.png| JPG files(*.jpg)|*.jpg| All Files(*.*)|*.*";
                string imageLocation = "";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    // Check if the file extension is .png
                    if (Path.GetExtension(imageLocation).ToLower() == ".png")
                    {
                        imgView.ImageLocation = imageLocation;
                    }
                    else
                    {
                        MessageBox.Show("Please select a PNG file.", "Invalid File Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void tbxItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void parrotGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}

