namespace Final
{
    partial class CustomerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMain));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            Shop = new TabPage();
            Cart = new TabPage();
            imageList1 = new ImageList(components);
            Checkout = new TabPage();
            Account = new TabPage();
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(Shop);
            materialTabControl1.Controls.Add(Cart);
            materialTabControl1.Controls.Add(Checkout);
            materialTabControl1.Controls.Add(Account);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(794, 383);
            materialTabControl1.TabIndex = 0;
            // 
            // Shop
            // 
            Shop.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Shop.ImageKey = "shop32.png";
            Shop.Location = new Point(4, 29);
            Shop.Name = "Shop";
            Shop.Padding = new Padding(3);
            Shop.Size = new Size(786, 350);
            Shop.TabIndex = 0;
            Shop.Text = "Shop";
            Shop.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            Cart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cart.ImageKey = "shopping-cart.png";
            Cart.Location = new Point(4, 29);
            Cart.Name = "Cart";
            Cart.Padding = new Padding(3);
            Cart.Size = new Size(786, 350);
            Cart.TabIndex = 1;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "alert.png");
            imageList1.Images.SetKeyName(1, "back32.png");
            imageList1.Images.SetKeyName(2, "back-button.png");
            imageList1.Images.SetKeyName(3, "bag32.png");
            imageList1.Images.SetKeyName(4, "box.png");
            imageList1.Images.SetKeyName(5, "cart32.png");
            imageList1.Images.SetKeyName(6, "cog-wheel.png");
            imageList1.Images.SetKeyName(7, "distribution.png");
            imageList1.Images.SetKeyName(8, "email.png");
            imageList1.Images.SetKeyName(9, "file.png");
            imageList1.Images.SetKeyName(10, "home.png");
            imageList1.Images.SetKeyName(11, "icons8-exit-50.png");
            imageList1.Images.SetKeyName(12, "minus-sign.png");
            imageList1.Images.SetKeyName(13, "padlock.png");
            imageList1.Images.SetKeyName(14, "plus.png");
            imageList1.Images.SetKeyName(15, "reject.png");
            imageList1.Images.SetKeyName(16, "search-interface-symbol.png");
            imageList1.Images.SetKeyName(17, "shop.png");
            imageList1.Images.SetKeyName(18, "shop32.png");
            imageList1.Images.SetKeyName(19, "shopping-bag.png");
            imageList1.Images.SetKeyName(20, "shopping-cart.png");
            imageList1.Images.SetKeyName(21, "supply-chain.png");
            imageList1.Images.SetKeyName(22, "trash.png");
            imageList1.Images.SetKeyName(23, "unlock.png");
            imageList1.Images.SetKeyName(24, "user.png");
            imageList1.Images.SetKeyName(25, "user32.png");
            // 
            // Checkout
            // 
            Checkout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Checkout.ImageKey = "shopping-bag.png";
            Checkout.Location = new Point(4, 29);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(786, 350);
            Checkout.TabIndex = 2;
            Checkout.Text = "Checkout";
            Checkout.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            Account.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Account.ImageKey = "user.png";
            Account.Location = new Point(4, 29);
            Account.Name = "Account";
            Account.Size = new Size(786, 350);
            Account.TabIndex = 3;
            Account.Text = "Account";
            Account.UseVisualStyleBackColor = true;
            // 
            // CustomerMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "CustomerMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello User!";
            Load += CustomerMain_Load;
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Shop;
        private TabPage Cart;
        private ImageList imageList1;
        private TabPage Checkout;
        private TabPage Account;
    }
}