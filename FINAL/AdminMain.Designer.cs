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
            inventory = new TabPage();
            supplier = new TabPage();
            sales = new TabPage();
            about = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
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
            materialTabControl1.Size = new Size(794, 383);
            materialTabControl1.TabIndex = 0;
            // 
            // home
            // 
            home.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home.ImageKey = "home.png";
            home.Location = new Point(4, 29);
            home.Name = "home";
            home.Padding = new Padding(3);
            home.Size = new Size(786, 350);
            home.TabIndex = 0;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // inventory
            // 
            inventory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventory.ImageKey = "box.png";
            inventory.Location = new Point(4, 29);
            inventory.Name = "inventory";
            inventory.Padding = new Padding(3);
            inventory.Size = new Size(786, 350);
            inventory.TabIndex = 1;
            inventory.Text = "Inventory";
            inventory.UseVisualStyleBackColor = true;
            // 
            // supplier
            // 
            supplier.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplier.ImageKey = "distribution.png";
            supplier.Location = new Point(4, 29);
            supplier.Name = "supplier";
            supplier.Size = new Size(786, 350);
            supplier.TabIndex = 2;
            supplier.Text = "Supplier";
            supplier.UseVisualStyleBackColor = true;
            // 
            // sales
            // 
            sales.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sales.ImageKey = "file.png";
            sales.Location = new Point(4, 29);
            sales.Name = "sales";
            sales.Size = new Size(786, 350);
            sales.TabIndex = 3;
            sales.Text = "Sales";
            sales.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            about.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            about.ImageKey = "user32.png";
            about.Location = new Point(4, 29);
            about.Name = "about";
            about.Size = new Size(786, 350);
            about.TabIndex = 5;
            about.Text = "About";
            about.UseVisualStyleBackColor = true;
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
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello Admin!";
            Load += AdminMain_Load;
            materialTabControl1.ResumeLayout(false);
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
    }
}