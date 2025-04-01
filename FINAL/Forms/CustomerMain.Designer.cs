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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelSearch = new Panel();
            Cart = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Checkout = new TabPage();
            flowLayoutPanel3 = new FlowLayoutPanel();
            Account = new TabPage();
            imageList1 = new ImageList(components);
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialTabControl1.SuspendLayout();
            Shop.SuspendLayout();
            Cart.SuspendLayout();
            Checkout.SuspendLayout();
            Account.SuspendLayout();
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
            materialTabControl1.Size = new Size(971, 453);
            materialTabControl1.TabIndex = 0;
            // 
            // Shop
            // 
            Shop.Controls.Add(flowLayoutPanel1);
            Shop.Controls.Add(panelSearch);
            Shop.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Shop.ImageKey = "shop32.png";
            Shop.Location = new Point(4, 29);
            Shop.Name = "Shop";
            Shop.Padding = new Padding(3);
            Shop.Size = new Size(963, 420);
            Shop.TabIndex = 0;
            Shop.Text = "Shop";
            Shop.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(957, 381);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panelSearch
            // 
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(3, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(957, 33);
            panelSearch.TabIndex = 0;
            // 
            // Cart
            // 
            Cart.Controls.Add(flowLayoutPanel2);
            Cart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cart.ImageKey = "shopping-cart.png";
            Cart.Location = new Point(4, 29);
            Cart.Name = "Cart";
            Cart.Padding = new Padding(3);
            Cart.Size = new Size(963, 420);
            Cart.TabIndex = 1;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(957, 414);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // Checkout
            // 
            Checkout.Controls.Add(flowLayoutPanel3);
            Checkout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Checkout.ImageKey = "shopping-bag.png";
            Checkout.Location = new Point(4, 29);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(963, 420);
            Checkout.TabIndex = 2;
            Checkout.Text = "Checkout";
            Checkout.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(963, 420);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // Account
            // 
            Account.Controls.Add(materialButton1);
            Account.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Account.ImageKey = "user.png";
            Account.Location = new Point(4, 29);
            Account.Name = "Account";
            Account.Size = new Size(963, 420);
            Account.TabIndex = 3;
            Account.Text = "Account";
            Account.UseVisualStyleBackColor = true;
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
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(437, 357);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(82, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Log Out";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // CustomerMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 520);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "CustomerMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello User!";
            Load += CustomerMain_Load;
            materialTabControl1.ResumeLayout(false);
            Shop.ResumeLayout(false);
            Cart.ResumeLayout(false);
            Checkout.ResumeLayout(false);
            Account.ResumeLayout(false);
            Account.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Shop;
        private TabPage Cart;
        private ImageList imageList1;
        private TabPage Checkout;
        private TabPage Account;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelSearch;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}