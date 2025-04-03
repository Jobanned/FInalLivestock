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
            panel2 = new Panel();
            dgvInventory = new DataGridView();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnSearchItem = new Button();
            imageList1 = new ImageList(components);
            btnAddItem = new Button();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvInventory);
            panel2.Controls.Add(btnDelete);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(461, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 419);
            panel2.TabIndex = 1;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Top;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(496, 266);
            dgvInventory.TabIndex = 26;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(28, 307);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(461, 379);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchItem);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 40);
            panel1.TabIndex = 3;
            // 
            // btnSearchItem
            // 
            btnSearchItem.Dock = DockStyle.Right;
            btnSearchItem.FlatStyle = FlatStyle.Popup;
            btnSearchItem.ImageKey = "search-interface-symbol.png";
            btnSearchItem.ImageList = imageList1;
            btnSearchItem.Location = new Point(361, 0);
            btnSearchItem.Name = "btnSearchItem";
            btnSearchItem.Size = new Size(50, 40);
            btnSearchItem.TabIndex = 2;
            btnSearchItem.UseVisualStyleBackColor = true;
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
            btnAddItem.Location = new Point(411, 0);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(50, 40);
            btnAddItem.TabIndex = 1;
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Item";
            textBox1.Size = new Size(363, 40);
            textBox1.TabIndex = 0;
            // 
            // AdminInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "AdminInventory";
            Size = new Size(957, 419);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dgvInventory;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnSearchItem;
        private ImageList imageList1;
        private Button btnAddItem;
        private MaterialSkin.Controls.MaterialButton btnDelete;
    }
}
