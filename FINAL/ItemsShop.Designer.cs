namespace Final
{
    partial class ItemsShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsShop));
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            imgView = new PictureBox();
            btnAddtoCart = new Button();
            imageList1 = new ImageList(components);
            btnCheckout = new Button();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(btnCheckout);
            parrotGradientPanel1.Controls.Add(btnAddtoCart);
            parrotGradientPanel1.Controls.Add(label3);
            parrotGradientPanel1.Controls.Add(label2);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Controls.Add(imgView);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(307, 288);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 3;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(13, 111);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(13, 167);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 2;
            label2.Text = "Quantity Left:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 1;
            label1.Text = "Price:";
            // 
            // imgView
            // 
            imgView.BackColor = SystemColors.AppWorkspace;
            imgView.Location = new Point(165, 13);
            imgView.Name = "imgView";
            imgView.Size = new Size(125, 103);
            imgView.SizeMode = PictureBoxSizeMode.Zoom;
            imgView.TabIndex = 0;
            imgView.TabStop = false;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.Transparent;
            btnAddtoCart.FlatAppearance.BorderColor = Color.White;
            btnAddtoCart.FlatStyle = FlatStyle.Flat;
            btnAddtoCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddtoCart.ForeColor = Color.Transparent;
            btnAddtoCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddtoCart.ImageKey = "shopping-cart.png";
            btnAddtoCart.ImageList = imageList1;
            btnAddtoCart.Location = new Point(3, 237);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(152, 51);
            btnAddtoCart.TabIndex = 54;
            btnAddtoCart.Text = "Add to Cart";
            btnAddtoCart.TextAlign = ContentAlignment.MiddleRight;
            btnAddtoCart.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "checkout.png");
            imageList1.Images.SetKeyName(1, "shopping-cart.png");
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Transparent;
            btnCheckout.FlatAppearance.BorderColor = Color.White;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.Transparent;
            btnCheckout.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckout.ImageKey = "checkout.png";
            btnCheckout.ImageList = imageList1;
            btnCheckout.Location = new Point(155, 237);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(152, 51);
            btnCheckout.TabIndex = 55;
            btnCheckout.Text = "Proceeed to\r\nCheckout";
            btnCheckout.TextAlign = ContentAlignment.MiddleRight;
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += button1_Click;
            // 
            // ItemsShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotGradientPanel1);
            Name = "ItemsShop";
            Size = new Size(307, 288);
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox imgView;
        private Button btnAddtoCart;
        private ImageList imageList1;
        private Button btnCheckout;
    }
}
