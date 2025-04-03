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
    public partial class UCShop : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        string newInfo = "";
        public UCShop()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadItems();
        }
        private void InitializeDatabase()
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");

                string query = @"SELECT Inventory.ID, Inventory.Item, Inventory.Quantity, Inventory.Price, Inventory.Image 
                                FROM Inventory";

                da = new OleDbDataAdapter(query, myConn);
                ds = new DataSet();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
        }
        private void LoadItems()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                ds?.Clear();

                using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb"))
                {
                    myConn.Open();
                    da?.Fill(ds, "Inventory");

                    if (ds?.Tables["Inventory"] != null)
                    {
                        foreach (DataRow row in ds.Tables["Inventory"].Rows)
                        {
                            ItemsShop item = new ItemsShop
                            {
                                ItemID = row["ID"].ToString(),
                                ItemName = row["Item"].ToString(),
                                Quantity = row["Quantity"].ToString(),
                                Price = row["Price"].ToString(),
                                ItemImage = row["Image"] // This will handle both Image and byte[] types
                            };

                            flowLayoutPanel1.Controls.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

    }
}
