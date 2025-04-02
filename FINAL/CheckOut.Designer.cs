namespace Final
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            imgView = new PictureBox();
            lblName = new Label();
            label1 = new Label();
            lblQuantity = new Label();
            btnAddtoCart = new Button();
            imageList1 = new ImageList(components);
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(btnAddtoCart);
            parrotGradientPanel1.Controls.Add(lblQuantity);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Controls.Add(lblName);
            parrotGradientPanel1.Controls.Add(imgView);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(627, 245);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 2;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // imgView
            // 
            imgView.BackColor = SystemColors.AppWorkspace;
            imgView.Location = new Point(26, 61);
            imgView.Name = "imgView";
            imgView.Size = new Size(125, 103);
            imgView.SizeMode = PictureBoxSizeMode.Zoom;
            imgView.TabIndex = 1;
            imgView.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Transparent;
            lblName.Location = new Point(173, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Item Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(173, 139);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 3;
            label1.Text = "Quantity:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Transparent;
            lblQuantity.Location = new Point(263, 139);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(22, 25);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "0";
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.Transparent;
            btnAddtoCart.FlatAppearance.BorderColor = Color.White;
            btnAddtoCart.FlatStyle = FlatStyle.Flat;
            btnAddtoCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddtoCart.ForeColor = Color.Transparent;
            btnAddtoCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddtoCart.ImageKey = "bin.png";
            btnAddtoCart.ImageList = imageList1;
            btnAddtoCart.Location = new Point(504, 180);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(108, 51);
            btnAddtoCart.TabIndex = 55;
            btnAddtoCart.Text = "Remove";
            btnAddtoCart.TextAlign = ContentAlignment.MiddleRight;
            btnAddtoCart.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bin.png");
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotGradientPanel1);
            Name = "CheckOut";
            Size = new Size(627, 245);
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private PictureBox imgView;
        private Label lblQuantity;
        private Label label1;
        private Label lblName;
        private Button btnAddtoCart;
        private ImageList imageList1;
    }
}
