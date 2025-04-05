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
    public partial class SuppliersContacts : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public SuppliersContacts()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");
            da = new OleDbDataAdapter("SELECT *FROM Supplier", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Supplier");
            dgvSuppliers.DataSource = ds.Tables["Supplier"];
            myConn.Close();
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvSuppliers.Rows[indexRow];

            tbxSupplierName.Text = row.Cells[1].Value.ToString();
            tbxPhone.Text = row.Cells[2].Value.ToString();
            tbxAddress.Text = row.Cells[3].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        public void clearFields()
        {
            tbxSupplierName.Text = "";
            tbxPhone.Text = "";
            tbxAddress.Text = "";
            tbxItem.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");
            da = new OleDbDataAdapter("SELECT *FROM Inventory", myConn);
            string query = "Insert into Supplier ([SupplierName], [PhoneNumber], [Address], [Item]) values (@name, @phonenum, @address, @item)";
            myConn.Open();
            if (tbxSupplierName.Text == string.Empty || tbxPhone.Text == string.Empty || tbxAddress.Text == string.Empty || tbxItem.Text == string.Empty)
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@name", tbxSupplierName.Text);
            cmd.Parameters.AddWithValue("@phonenum", tbxPhone.Text);
            cmd.Parameters.AddWithValue("@address", tbxAddress.Text);
            cmd.Parameters.AddWithValue("@item", tbxItem.Text);
            cmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLoad_Click(sender, e);
            clearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb"))
                {
                    string query = "DELETE FROM [Supplier] WHERE SupplierName = @name";
                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@name", dgvSuppliers.CurrentRow.Cells[1].Value);

                        myConn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No record was deleted. Please double check.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            btnLoad_Click(sender, e);
            clearFields();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Supplier Set [SupplierName] = @name, [PhoneNumber] = @phonenum, [Address] = @address, [Item] = @item  Where [SupplierName] = @name"; 
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@name", tbxSupplierName.Text);
            cmd.Parameters.AddWithValue("@phonenum", tbxPhone.Text);
            cmd.Parameters.AddWithValue("@address", tbxAddress.Text);
            cmd.Parameters.AddWithValue("@item", tbxItem.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLoad_Click(sender, e);
            clearFields();
        }
    }
}
