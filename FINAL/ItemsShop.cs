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
using static Final.CartItem;
//using static Final.Carts;

namespace Final
{
    public partial class ItemsShop : UserControl
    {
        public event Action<CartItem> ItemAddedToCart;
        public bool IsCartConnected => ItemAddedToCart != null;

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
            set => lblPrice.Text = $"₱{value}";
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
            try
            {
                var assembly = Assembly.GetExecutingAssembly();

                // Try both possible resource name formats
                string[] possibleResources = {
            "feeding.Resources.default_item.png",  // Original path
            $"{assembly.GetName().Name}.Resources.default_item.png",  // Project namespace
            "Final.Resources.default_item.png"     // Common fallback
        };

                foreach (var resourceName in possibleResources)
                {
                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    {
                        if (stream != null)
                        {
                            return Image.FromStream(stream);
                        }
                    }
                }
            }
            catch
            {
                // Fall through to default image
            }

            // Create a simple placeholder image
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                g.DrawString("No Image", new Font("Arial", 8), Brushes.Black, 10, 45);
            }
            return bmp;
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                var cartItem = new CartItem
                {
                    ItemID = this.ItemID,
                    ItemName = this.ItemName,
                    Quantity = string.IsNullOrWhiteSpace(this.Quantity) ? "1" : this.Quantity,
                    Price = (this.Price ?? "0").Replace("₱", "").Trim(),
                    ItemImage = this.imgView.Image ?? LoadDefaultItemImage()
                };

                if (ItemAddedToCart == null)
                {
                    MessageBox.Show("Cart system is not ready yet", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ItemAddedToCart.Invoke(cartItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't add to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }
}
