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
    public partial class UCCheckout : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        string newInfo = "";
        public UCCheckout()
        {
            InitializeComponent();
            InitializeDatabase();
          //  LoadPlants();
        }
        private void InitializeDatabase()
        {
       /*     try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");

                string query = @"SELECT Plants.PlantID, Plants.PlantName, Plants.WateringFrequency, Plants.FertilizationSchedule, Plants.PlantImage FROM Plants;";

                da = new OleDbDataAdapter(query, myConn);
                ds = new DataSet();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }*/
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
