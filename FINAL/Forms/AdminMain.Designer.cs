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
            inventory = new TabPage();
            pnlInventory = new Panel();
            adminInventory1 = new AdminInventory();
            pnlSearchInventory = new Panel();
            tbxSearchInv = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            supplier = new TabPage();
            pnlSearchSupplier = new Panel();
            tbxSearchSupp = new TextBox();
            button1 = new Button();
            button2 = new Button();
            sales = new TabPage();
            about = new TabPage();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            pnlSupplier = new Panel();
            suppliersContacts1 = new SuppliersContacts();
            materialTabControl1.SuspendLayout();
            home.SuspendLayout();
            inventory.SuspendLayout();
            pnlInventory.SuspendLayout();
            pnlSearchInventory.SuspendLayout();
            supplier.SuspendLayout();
            pnlSearchSupplier.SuspendLayout();
            about.SuspendLayout();
            pnlSupplier.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(home);
            materialTabControl1.Controls.Add(inventory);
            materialTabControl1.Controls.Add(sales);
            materialTabControl1.Controls.Add(about);
            materialTabControl1.Controls.Add(supplier);
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
            pnlHome.Dock = DockStyle.Fill;
            pnlHome.Location = new Point(3, 3);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(957, 414);
            pnlHome.TabIndex = 0;
            // 
            // inventory
            // 
            inventory.Controls.Add(pnlInventory);
            inventory.Controls.Add(pnlSearchInventory);
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
            pnlInventory.Location = new Point(3, 50);
            pnlInventory.Name = "pnlInventory";
            pnlInventory.Size = new Size(957, 367);
            pnlInventory.TabIndex = 1;
            // 
            // adminInventory1
            // 
            adminInventory1.AutoSize = true;
            adminInventory1.Dock = DockStyle.Fill;
            adminInventory1.Location = new Point(0, 0);
            adminInventory1.Margin = new Padding(4);
            adminInventory1.Name = "adminInventory1";
            adminInventory1.Size = new Size(957, 367);
            adminInventory1.TabIndex = 0;
            // 
            // pnlSearchInventory
            // 
            pnlSearchInventory.Controls.Add(tbxSearchInv);
            pnlSearchInventory.Controls.Add(btnSearch);
            pnlSearchInventory.Controls.Add(btnAdd);
            pnlSearchInventory.Dock = DockStyle.Top;
            pnlSearchInventory.Location = new Point(3, 3);
            pnlSearchInventory.Name = "pnlSearchInventory";
            pnlSearchInventory.Size = new Size(957, 47);
            pnlSearchInventory.TabIndex = 0;
            // 
            // tbxSearchInv
            // 
            tbxSearchInv.Dock = DockStyle.Top;
            tbxSearchInv.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearchInv.Location = new Point(0, 0);
            tbxSearchInv.Name = "tbxSearchInv";
            tbxSearchInv.PlaceholderText = "Search Item";
            tbxSearchInv.Size = new Size(839, 51);
            tbxSearchInv.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Dock = DockStyle.Right;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(839, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(59, 47);
            btnSearch.TabIndex = 4;
            toolTip1.SetToolTip(btnSearch, "Search");
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Dock = DockStyle.Right;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(898, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(59, 47);
            btnAdd.TabIndex = 3;
            toolTip1.SetToolTip(btnAdd, "Add Item");
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // supplier
            // 
            supplier.Controls.Add(pnlSupplier);
            supplier.Controls.Add(pnlSearchSupplier);
            supplier.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplier.ImageKey = "distribution.png";
            supplier.Location = new Point(4, 29);
            supplier.Name = "supplier";
            supplier.Size = new Size(963, 420);
            supplier.TabIndex = 2;
            supplier.Text = "Supplier";
            supplier.UseVisualStyleBackColor = true;
            // 
            // pnlSearchSupplier
            // 
            pnlSearchSupplier.Controls.Add(tbxSearchSupp);
            pnlSearchSupplier.Controls.Add(button1);
            pnlSearchSupplier.Controls.Add(button2);
            pnlSearchSupplier.Dock = DockStyle.Top;
            pnlSearchSupplier.Location = new Point(0, 0);
            pnlSearchSupplier.Name = "pnlSearchSupplier";
            pnlSearchSupplier.Size = new Size(963, 47);
            pnlSearchSupplier.TabIndex = 1;
            // 
            // tbxSearchSupp
            // 
            tbxSearchSupp.Dock = DockStyle.Fill;
            tbxSearchSupp.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearchSupp.Location = new Point(0, 0);
            tbxSearchSupp.Name = "tbxSearchSupp";
            tbxSearchSupp.PlaceholderText = "Search Supplier";
            tbxSearchSupp.Size = new Size(845, 51);
            tbxSearchSupp.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(845, 0);
            button1.Name = "button1";
            button1.Size = new Size(59, 47);
            button1.TabIndex = 4;
            button1.Tag = "";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolTip1.SetToolTip(button1, "Search");
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(904, 0);
            button2.Name = "button2";
            button2.Size = new Size(59, 47);
            button2.TabIndex = 3;
            toolTip1.SetToolTip(button2, "Add Item");
            button2.UseVisualStyleBackColor = true;
            // 
            // sales
            // 
            sales.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sales.ImageKey = "file.png";
            sales.Location = new Point(4, 29);
            sales.Name = "sales";
            sales.Size = new Size(963, 420);
            sales.TabIndex = 3;
            sales.Text = "Sales";
            sales.UseVisualStyleBackColor = true;
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
            // pnlSupplier
            // 
            pnlSupplier.Controls.Add(suppliersContacts1);
            pnlSupplier.Dock = DockStyle.Fill;
            pnlSupplier.Location = new Point(0, 47);
            pnlSupplier.Name = "pnlSupplier";
            pnlSupplier.Size = new Size(963, 373);
            pnlSupplier.TabIndex = 2;
            // 
            // suppliersContacts1
            // 
            suppliersContacts1.Dock = DockStyle.Fill;
            suppliersContacts1.Location = new Point(0, 0);
            suppliersContacts1.Name = "suppliersContacts1";
            suppliersContacts1.Size = new Size(963, 373);
            suppliersContacts1.TabIndex = 0;
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
            inventory.ResumeLayout(false);
            pnlInventory.ResumeLayout(false);
            pnlInventory.PerformLayout();
            pnlSearchInventory.ResumeLayout(false);
            pnlSearchInventory.PerformLayout();
            supplier.ResumeLayout(false);
            pnlSearchSupplier.ResumeLayout(false);
            pnlSearchSupplier.PerformLayout();
            about.ResumeLayout(false);
            about.PerformLayout();
            pnlSupplier.ResumeLayout(false);
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
        private Panel pnlHome;
        private Panel pnlSearchInventory;
        private Button btnAdd;
        private TextBox tbxSearchInv;
        private Button btnSearch;
        private Panel pnlSearchSupplier;
        private TextBox tbxSearchSupp;
        private Button button1;
        private Button button2;
        private ToolTip toolTip1;
        private Panel pnlInventory;
        private AdminInventory adminInventory1;
        private Panel pnlSupplier;
        private SuppliersContacts suppliersContacts1;
    }
}