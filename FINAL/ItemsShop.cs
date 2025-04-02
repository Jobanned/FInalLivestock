using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class ItemsShop : UserControl
    {

        public ItemsShop()
        {
            InitializeComponent();
        }
        public string ItemID { get; set; }
        public string ItemName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string Quantity
        {
            get => lblQty.Text;
            set => lblQty.Text = value;
        }

        public string Price
        {
            get => lblPrice.Text;
            set => lblPrice.Text = $"₱: {value}";
        }
        public object ItemImage
        {
            set
            {
                if (value is Image img)
                {
                    imgView.Image = img;
                }
                else if (value is byte[] imageBytes && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        imgView.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    imgView.Image = LoadDefaultItemImage();
                }
            }
        }


        // Load embedded default image
        private Image LoadDefaultItemImage()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = "feeding.Resources.default_item.png";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    return Image.FromStream(stream);
                }
            }


            return new Bitmap(100, 100);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
