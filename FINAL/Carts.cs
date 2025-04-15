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

namespace Final
{
    public partial class Carts : UserControl
    {
        private CartItem _cartItem;
        private decimal _originalPrice;
        public Action<CartItem> GetUpdatedCartItemCallback { get; set; }
        public Carts()
        {
            InitializeComponent();
            numericQuantity.Minimum = 1;
            numericQuantity.ValueChanged += numericQuantity_ValueChanged;
        }

        public void SetCartItem(CartItem item)
        {
            _cartItem = item;
            _originalPrice = decimal.Parse(item.Price);

            // Update UI elements
            lblName.Text = item.ItemName;
            lblPrice.Text = $"₱{_originalPrice:N2}";
            imgView.Image = item.ItemImage;
            numericQuantity.Value = int.Parse(item.Quantity);

            UpdateTotalPrice();
        }
        public CartItem GetUpdatedCartItem()
        {
            return _cartItem;
        }
        private void imgView_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
        private void UpdateTotalPrice()
        {
            if (_cartItem != null)
            {
                int quantity = (int)numericQuantity.Value;
                decimal total = _originalPrice * quantity;
                lblPrice.Text = $"₱{total:N2}";

                // Update the cart item
                _cartItem.Quantity = quantity.ToString();
                _cartItem.Price = total.ToString("N2");
            }
        }
        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

            // Notify parent of changes
            GetUpdatedCartItemCallback?.Invoke(_cartItem);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GetUpdatedCartItemCallback?.Invoke(null);
        }
    }
}
