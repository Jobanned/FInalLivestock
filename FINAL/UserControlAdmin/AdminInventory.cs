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



       /* private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [Inventory] SET [Item] = @itemname, [Quantity] = @quantity, [Price] = @price, [FeedType] = @feedtype, [Status] = @status, [Image] = @image, WHERE Item = @item";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@itemname", tbxItemName.Text);
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(tbxStock.Text));
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(tbxPrice.Text));
            cmd.Parameters.AddWithValue("@feedtype", cbxType.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@status", cbxStatus.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@id", dgvInventory.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
            btnLoad_Click(sender, e);
        } */

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
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
                    string query = "DELETE FROM [Inventory] WHERE ID = @id";
                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@id", dgvInventory.CurrentRow.Cells[0].Value);

                        myConn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No record was deleted. Please check the Student ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            btnLoad_Click(sender, e);
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvInventory.Rows[indexRow];

          /*  tbxItemName.Text = row.Cells[1].Value.ToString();
            tbxStock.Text = row.Cells[2].Value.ToString();
            tbxPrice.Text = row.Cells[3].Value.ToString();
            cbxType.SelectedItem = row.Cells[4].Value.ToString();
            cbxStatus.SelectedItem = row.Cells[5].Value.ToString(); */
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();

            int x = (this.ClientSize.Width - addItem.Width) / 2;
            int y = (this.ClientSize.Height - addItem.Height) / 2;

            addItem.Location = new Point(x, y);
            addItem.Size = new Size(384, 499);

            this.Controls.Add(addItem);
            addItem.BringToFront();
        }
    }
}
