using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final.ItemsShop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Final
{
    public partial class CustomerCart : UserControl
    {
        private ItemsShop _itemsShop;
        private List<CartItem> cartItems = new List<CartItem>();
        public CustomerCart()
        {
            InitializeComponent();
            SetupConnection();

        }
        public void RegisterItemsShop(ItemsShop shop)
        {
            if (shop != null)
            {
                shop.ItemAddedToCart += AddItemToCart;
            }
        }
        public void ConnectToItemsShop(ItemsShop shop)
        {
            _itemsShop = shop;
            if (_itemsShop != null)
            {
                _itemsShop.ItemAddedToCart += AddItemToCart;
            }
        }
        private void SetupConnection()
        {
            this.Load += (s, e) =>
            {
                // Try to find ItemsShop in the same parent container
                var parent = this.Parent;
                if (parent != null)
                {
                    var itemsShops = parent.Controls.OfType<ItemsShop>();
                    foreach (var shop in itemsShops)
                    {
                        shop.ItemAddedToCart += AddItemToCart;
                    }
                }
            };
        }

        public void AddItemToCart(CartItem item)
        {
            // Check if item already exists in cart
            var existingItem = cartItems.FirstOrDefault(i => i.ItemID == item.ItemID);

            if (existingItem != null)
            {
                // Update quantity if item exists
                int currentQty, newQty;
                if (int.TryParse(existingItem.Quantity, out currentQty) &&
                    int.TryParse(item.Quantity, out newQty))
                {
                    existingItem.Quantity = (currentQty + newQty).ToString();
                }
            }
            else
            {
                // Add new item to cart
                cartItems.Add(item);
            }

            UpdateCartDisplay();
        }
        private void UpdateCartDisplay()
        {
            flowLayoutPanelCartItems.Controls.Clear();
            decimal total = 0;

            foreach (var item in cartItems)
            {
                // Create an instance of your Carts control for each item
                var cartItemControl = new Carts();
                cartItemControl.SetCartItem(item);

                // Style the control
                cartItemControl.Width = flowLayoutPanelCartItems.Width - 25;
                cartItemControl.Margin = new Padding(5);

                // Handle when editing is complete
                cartItemControl.GetUpdatedCartItemCallback = (updatedItem) =>
                {
                    if (updatedItem == null)
                    {
                        // Remove the item
                        cartItems.RemoveAll(ci => ci.ItemID == item.ItemID);
                    }
                    else
                    {
                        var index = cartItems.FindIndex(i => i.ItemID == updatedItem.ItemID);
                        if (index >= 0)
                        {
                            cartItems[index] = updatedItem;
                        }
                    }

                    UpdateCartDisplay();
                };

                flowLayoutPanelCartItems.Controls.Add(cartItemControl);

                // Calculate total
                total += decimal.Parse(item.Price.Replace("₱", "")) * int.Parse(item.Quantity);
            }

            lblTotalPrice.Text = $"Total: ₱{total.ToString("N2")}";
        }
        

        private void flowLayoutPanelCartItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnConirmBuy_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Checkout",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal grandTotal = cartItems.Sum(item =>
                decimal.Parse(item.Price.Replace("₱", "")) * int.Parse(item.Quantity));

            var result = MessageBox.Show(
                $"Confirm purchase of {cartItems.Count} items for ₱{grandTotal:N2}?",
                "Confirm Purchase",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Process payment logic would go here
                MessageBox.Show("Purchase completed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cartItems.Clear();
                UpdateCartDisplay();
            }
        }
    }
}

