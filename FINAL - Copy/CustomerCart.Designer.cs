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
            imageList1 = new ImageList(components);
            tbxSearch = new TextBox();
            panel2 = new Panel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            btnConirmBuy = new Button();
            lblTotalPrice = new Label();
            label1 = new Label();
            flowLayoutPanelCartItems = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            parrotGradientPanel1.SuspendLayout();
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
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search-interface-symbol.png");
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
            // panel2
            // 
            panel2.Controls.Add(parrotGradientPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 327);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 87);
            panel2.TabIndex = 2;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(btnConirmBuy);
            parrotGradientPanel1.Controls.Add(lblTotalPrice);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(957, 87);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 0;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(56, 188, 95);
            // 
            // btnConirmBuy
            // 
            btnConirmBuy.BackColor = Color.Transparent;
            btnConirmBuy.FlatAppearance.BorderColor = Color.White;
            btnConirmBuy.FlatStyle = FlatStyle.Flat;
            btnConirmBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConirmBuy.ForeColor = Color.Transparent;
            btnConirmBuy.ImageKey = "(none)";
            btnConirmBuy.ImageList = imageList1;
            btnConirmBuy.Location = new Point(755, 20);
            btnConirmBuy.Name = "btnConirmBuy";
            btnConirmBuy.Size = new Size(139, 51);
            btnConirmBuy.TabIndex = 56;
            btnConirmBuy.Text = "Confirm Buy";
            btnConirmBuy.UseVisualStyleBackColor = false;
            btnConirmBuy.Click += btnConirmBuy_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Transparent;
            lblTotalPrice.Location = new Point(112, 31);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(94, 25);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "totalprice";
            lblTotalPrice.Click += lblTotalPrice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "Total Price:";
            // 
            // flowLayoutPanelCartItems
            // 
            flowLayoutPanelCartItems.AutoScroll = true;
            flowLayoutPanelCartItems.Dock = DockStyle.Fill;
            flowLayoutPanelCartItems.Location = new Point(0, 37);
            flowLayoutPanelCartItems.Name = "flowLayoutPanelCartItems";
            flowLayoutPanelCartItems.Size = new Size(957, 290);
            flowLayoutPanelCartItems.TabIndex = 3;
            flowLayoutPanelCartItems.WrapContents = false;
            flowLayoutPanelCartItems.Paint += flowLayoutPanelCartItems_Paint;
            // 
            // CustomerCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelCartItems);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerCart";
            Size = new Size(957, 414);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSearch;
        private TextBox tbxSearch;
        private ImageList imageList1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelCartItems;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label lblTotalPrice;
        private Label label1;
        private Button btnConirmBuy;
    }
}
