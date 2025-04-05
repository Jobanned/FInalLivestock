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
            LoadData();
        }
        private void LoadData()
        {

            btnLoad_Click(null, EventArgs.Empty);
            LoadItemsToFlowPanel();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb"))
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Inventory", myConn);
                DataSet ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Inventory");
                dgvInventory.DataSource = ds.Tables["Inventory"];
            }
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
                    string query = "DELETE FROM [Inventory] WHERE Item = @item";
                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@item", dgvInventory.CurrentRow.Cells[1].Value);

                        myConn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("No record was deleted. Please double check.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
            }
        }
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvInventory.Rows[indexRow];

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ItemAdded += AddItem_ItemAdded;
            PositionAddItemControl(addItem);
        }
        private void AddItem_ItemAdded(object sender, AddItem.ItemAddedEventArgs e)
        {
            RefreshAllData();
        }
        private void PositionAddItemControl(AddItem addItem)
        {
            int x = (this.ClientSize.Width - addItem.Width) / 2;
            int y = (this.ClientSize.Height - addItem.Height) / 2;
            addItem.Location = new Point(x, y);
            addItem.Size = new Size(384, 499);
            this.Controls.Add(addItem);
            addItem.BringToFront();
        }
        private void RefreshAllData()
        {
            btnLoad_Click(null, EventArgs.Empty);
            LoadItemsToFlowPanel();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadItemsToFlowPanel()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb"))
                {
                    da = new OleDbDataAdapter("SELECT * FROM Inventory", myConn);
                    ds = new DataSet();
                    myConn.Open();
                    da.Fill(ds, "Inventory");

                    foreach (DataRow row in ds.Tables["Inventory"].Rows)
                    {
                        Items itemControl = new Items
                        {
                            ItemName = row["Item"].ToString(),
                            Quantity = Convert.ToInt32(row["Quantity"]),
                            Price = Convert.ToDecimal(row["Price"]),
                            CurrentFeedType = row["FeedType"].ToString(),
                            CurrentStatus = row["Status"].ToString()
                        };

                        if (row["Image"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])row["Image"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                itemControl.ItemImage = Image.FromStream(ms);
                            }
                        }
                        itemControl.DeleteClicked += (sender, e) => {
                            RefreshAllData();
                        };
                        flowLayoutPanel1.Controls.Add(itemControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items to panel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
