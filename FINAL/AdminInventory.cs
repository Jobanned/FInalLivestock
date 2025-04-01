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
using System.Xml.Linq;

namespace Final
{
    public partial class AdminInventory : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public AdminInventory()
        {
            InitializeComponent();
        }

        private bool emptyFields()
        {
            if (tbxItemName.Text == "" || tbxPrice.Text == "" || tbxStock.Text == "" || cbxStatus.SelectedIndex == -1 || cbxType.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");
            da = new OleDbDataAdapter("SELECT *FROM Inventory", myConn);
            string query = "Insert into Account ([ItemName], [Quantity], [Price], [FeedType], [Status], [Image]) values (@itemname, @quantity, @price, @feedtype, @status, @image)";
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
            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void clearFields()
        {
            tbxItemName.Text = "";
            tbxPrice.Text = "";
            tbxStock.Text = "";
            cbxStatus.SelectedIndex = -1;
            cbxType.SelectedIndex = -1;
            imgView.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill out all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    MessageBox.Show("Item updated successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");
            da = new OleDbDataAdapter("SELECT *FROM Inventory", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Inventory");
            dgvInventory.DataSource = ds.Tables["Inventory"];
            myConn.Close();
        }
    }
}
