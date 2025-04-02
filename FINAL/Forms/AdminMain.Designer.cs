namespace Final
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            home = new TabPage();
            pnlHome = new Panel();
            adminDashboard1 = new AdminDashboard();
            inventory = new TabPage();
            pnlInventory = new Panel();
            adminInventory1 = new AdminInventory();
            supplier = new TabPage();
            pnlSupplier = new Panel();
            suppliersContacts1 = new SuppliersContacts();
            sales = new TabPage();
            adminSales1 = new AdminSales();
            about = new TabPage();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            materialTabControl1.SuspendLayout();
            home.SuspendLayout();
            pnlHome.SuspendLayout();
            inventory.SuspendLayout();
            pnlInventory.SuspendLayout();
            supplier.SuspendLayout();
            pnlSupplier.SuspendLayout();
            sales.SuspendLayout();
            about.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(home);
            materialTabControl1.Controls.Add(inventory);
            materialTabControl1.Controls.Add(supplier);
            materialTabControl1.Controls.Add(sales);
            materialTabControl1.Controls.Add(about);
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
            // home
            // 
            home.Controls.Add(pnlHome);
            home.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home.ImageKey = "home.png";
            home.Location = new Point(4, 29);
            home.Name = "home";
            home.Padding = new Padding(3);
            home.Size = new Size(963, 420);
            home.TabIndex = 0;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // pnlHome
            // 
            pnlHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlHome.Controls.Add(adminDashboard1);
            pnlHome.Dock = DockStyle.Fill;
            pnlHome.Location = new Point(3, 3);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(957, 414);
            pnlHome.TabIndex = 0;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Dock = DockStyle.Fill;
            adminDashboard1.Location = new Point(0, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(957, 414);
            adminDashboard1.TabIndex = 0;
            // 
            // inventory
            // 
            inventory.Controls.Add(pnlInventory);
            inventory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventory.ImageKey = "box.png";
            inventory.Location = new Point(4, 29);
            inventory.Name = "inventory";
            inventory.Padding = new Padding(3);
            inventory.Size = new Size(963, 420);
            inventory.TabIndex = 1;
            inventory.Text = "Inventory";
            inventory.UseVisualStyleBackColor = true;
            // 
            // pnlInventory
            // 
            pnlInventory.Controls.Add(adminInventory1);
            pnlInventory.Dock = DockStyle.Fill;
            pnlInventory.Location = new Point(3, 3);
            pnlInventory.Name = "pnlInventory";
            pnlInventory.Size = new Size(957, 414);
            pnlInventory.TabIndex = 1;
            // 
            // adminInventory1
            // 
            adminInventory1.AutoSize = true;
            adminInventory1.Dock = DockStyle.Fill;
            adminInventory1.Location = new Point(0, 0);
            adminInventory1.Margin = new Padding(4);
            adminInventory1.Name = "adminInventory1";
            adminInventory1.Size = new Size(957, 414);
            adminInventory1.TabIndex = 0;
            // 
            // supplier
            // 
            supplier.Controls.Add(pnlSupplier);
            supplier.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplier.ImageKey = "distribution.png";
            supplier.Location = new Point(4, 29);
            supplier.Name = "supplier";
            supplier.Size = new Size(963, 420);
            supplier.TabIndex = 2;
            supplier.Text = "Supplier";
            supplier.UseVisualStyleBackColor = true;
            // 
            // pnlSupplier
            // 
            pnlSupplier.Controls.Add(suppliersContacts1);
            pnlSupplier.Dock = DockStyle.Fill;
            pnlSupplier.Location = new Point(0, 0);
            pnlSupplier.Name = "pnlSupplier";
            pnlSupplier.Size = new Size(963, 420);
            pnlSupplier.TabIndex = 2;
            // 
            // suppliersContacts1
            // 
            suppliersContacts1.Dock = DockStyle.Fill;
            suppliersContacts1.Location = new Point(0, 0);
            suppliersContacts1.Margin = new Padding(4);
            suppliersContacts1.Name = "suppliersContacts1";
            suppliersContacts1.Size = new Size(963, 420);
            suppliersContacts1.TabIndex = 0;
            // 
            // sales
            // 
            sales.Controls.Add(adminSales1);
            sales.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sales.ImageKey = "file.png";
            sales.Location = new Point(4, 29);
            sales.Name = "sales";
            sales.Size = new Size(963, 420);
            sales.TabIndex = 3;
            sales.Text = "Sales";
            sales.UseVisualStyleBackColor = true;
            // 
            // adminSales1
            // 
            adminSales1.Dock = DockStyle.Fill;
            adminSales1.Location = new Point(0, 0);
            adminSales1.Name = "adminSales1";
            adminSales1.Size = new Size(963, 420);
            adminSales1.TabIndex = 0;
            // 
            // about
            // 
            about.Controls.Add(materialButton1);
            about.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            about.ImageKey = "user32.png";
            about.Location = new Point(4, 29);
            about.Name = "about";
            about.Size = new Size(963, 420);
            about.TabIndex = 5;
            about.Text = "About";
            about.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(430, 362);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(82, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Log Out";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
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
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Search";
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 520);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello Admin!";
            materialTabControl1.ResumeLayout(false);
            home.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            inventory.ResumeLayout(false);
            pnlInventory.ResumeLayout(false);
            pnlInventory.PerformLayout();
            supplier.ResumeLayout(false);
            pnlSupplier.ResumeLayout(false);
            sales.ResumeLayout(false);
            about.ResumeLayout(false);
            about.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage home;
        private TabPage inventory;
        private ImageList imageList1;
        private TabPage supplier;
        private TabPage sales;
        private TabPage tabPage4;
        private TabPage about;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private ToolTip toolTip1;
        private Panel pnlInventory;
        private Panel pnlSupplier;
        private AdminInventory adminInventory1;
        private SuppliersContacts suppliersContacts1;
        private Panel pnlHome;
        private AdminDashboard adminDashboard1;
        private AdminSales adminSales1;
    }
}