namespace Final
{
    partial class CustomerCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCart));
            panel1 = new Panel();
            btnSearch = new Button();
            tbxSearch = new TextBox();
            imageList1 = new ImageList(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbxSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 37);
            panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Right;
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.ImageKey = "search-interface-symbol.png";
            btnSearch.ImageList = imageList1;
            btnSearch.Location = new Point(892, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 37);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            tbxSearch.Dock = DockStyle.Left;
            tbxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.Location = new Point(0, 0);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Search Item";
            tbxSearch.Size = new Size(894, 37);
            tbxSearch.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search-interface-symbol.png");
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 37);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(957, 377);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // CustomerCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "CustomerCart";
            Size = new Size(957, 414);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSearch;
        private TextBox tbxSearch;
        private ImageList imageList1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
