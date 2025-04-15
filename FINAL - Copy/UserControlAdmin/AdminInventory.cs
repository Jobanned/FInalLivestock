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
                //dgvInventory.DataSource = ds.Tables["Inventory"];
            }
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
                        itemControl.DeleteClicked += (sender, e) =>
                        {
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchItems(tbxSearch.Text);
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            SearchItems(tbxSearch.Text);
        }

        private void SearchItems(string searchText)
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb"))
                {
                    da = new OleDbDataAdapter($"SELECT * FROM Inventory WHERE Item LIKE '%{searchText}%' OR FeedType LIKE '%{searchText}%'", myConn);
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
                        itemControl.DeleteClicked += (sender, e) =>
                        {
                            RefreshAllData();
                        };
                        flowLayoutPanel1.Controls.Add(itemControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
