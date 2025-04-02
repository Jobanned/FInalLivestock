using Final.Forms;
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
    public partial class Items : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public event EventHandler DeleteClicked;
        public string CurrentFeedType { get; set; } = "Organic";
        public string CurrentStatus { get; set; } = "Available";

        public Items()
        {
            InitializeComponent();
        }
        public string ItemName
        {
            get => lblItemName.Text;
            set => lblItemName.Text = value;
        }

        public int Quantity
        {
            get => int.Parse(lblQuantity.Text.Replace("Stock: ", ""));
            set => lblQuantity.Text = $"Stock: {value}";
        }

        public decimal Price
        {
            get => decimal.Parse(lblPrice.Text.Replace("₱", ""));
            set => lblPrice.Text = $"₱{value:N2}";
        }

        public Image ItemImage
        {
            get => imgView.Image;
            set => imgView.Image = value;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditItems ei = new EditItems(
                    lblItemName.Text,                         // ItemName
                    int.Parse(lblQuantity.Text.Replace("Stock:","")),  // Quantity
                    decimal.Parse(lblPrice.Text.Replace("₱", "")),      // Price
                    imgView.Image,                             // ItemImage
                    CurrentFeedType,                           // FeedType
                    CurrentStatus                              // Status
                );
            //   ei.ShowDialog();  // Use ShowDialog() if you want it to be modal
            ei.ItemUpdated += (s, args) => {
                // Update the current item's properties
                this.ItemName = args.ItemName;
                this.Quantity = args.Quantity;
                this.Price = args.Price;
                this.ItemImage = args.Image;
                this.CurrentFeedType = args.FeedType;
                this.CurrentStatus = args.Status;
            };

            if (ei.ShowDialog() == DialogResult.OK)
            {
                // Notify parent that we need to refresh
                DeleteClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteClicked?.Invoke(this, EventArgs.Empty);
                this.Parent?.Controls.Remove(this);
            }

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}
