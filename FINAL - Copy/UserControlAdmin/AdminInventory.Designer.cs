namespace Final
{
    partial class AdminInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInventory));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnSearchItem = new Button();
            imageList1 = new ImageList(components);
            btnAddItem = new Button();
            tbxSearch = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(957, 379);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchItem);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(tbxSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 40);
            panel1.TabIndex = 3;
            // 
            // btnSearchItem
            // 
            btnSearchItem.Dock = DockStyle.Right;
            btnSearchItem.FlatStyle = FlatStyle.Popup;
            btnSearchItem.ImageKey = "search-interface-symbol.png";
            btnSearchItem.ImageList = imageList1;
            btnSearchItem.Location = new Point(857, 0);
            btnSearchItem.Name = "btnSearchItem";
            btnSearchItem.Size = new Size(50, 40);
            btnSearchItem.TabIndex = 2;
            btnSearchItem.UseVisualStyleBackColor = true;
            btnSearchItem.Click += btnSearchItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search-interface-symbol.png");
            imageList1.Images.SetKeyName(1, "add.png");
            // 
            // btnAddItem
            // 
            btnAddItem.Dock = DockStyle.Right;
            btnAddItem.FlatStyle = FlatStyle.Popup;
            btnAddItem.ImageKey = "add.png";
            btnAddItem.ImageList = imageList1;
            btnAddItem.Location = new Point(907, 0);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(50, 40);
            btnAddItem.TabIndex = 1;
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Dock = DockStyle.Fill;
            tbxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.Location = new Point(0, 0);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Search Item";
            tbxSearch.Size = new Size(957, 40);
            tbxSearch.TabIndex = 0;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // AdminInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "AdminInventory";
            Size = new Size(957, 419);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox tbxSearch;
        private Button btnSearchItem;
        private ImageList imageList1;
        private Button btnAddItem;
    }
}
