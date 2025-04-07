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
            label2 = new Label();
            nmrcQuantity = new NumericUpDown();
            btnRemove = new Button();
            imageList1 = new ImageList(components);
            lblPrice = new Label();
            label1 = new Label();
            lblName = new Label();
            imgView = new PictureBox();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgView).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(label2);
            parrotGradientPanel1.Controls.Add(nmrcQuantity);
            parrotGradientPanel1.Controls.Add(btnRemove);
            parrotGradientPanel1.Controls.Add(lblPrice);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Controls.Add(lblName);
            parrotGradientPanel1.Controls.Add(imgView);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(534, 215);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 2;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(173, 114);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 57;
            label2.Text = "Quantity:";
            // 
            // nmrcQuantity
            // 
            nmrcQuantity.Location = new Point(263, 112);
            nmrcQuantity.Name = "nmrcQuantity";
            nmrcQuantity.Size = new Size(57, 27);
            nmrcQuantity.TabIndex = 56;
            nmrcQuantity.ValueChanged += nmrcQuantity_ValueChanged;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Transparent;
            btnRemove.FlatAppearance.BorderColor = Color.White;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Transparent;
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.ImageKey = "bin.png";
            btnRemove.ImageList = imageList1;
            btnRemove.Location = new Point(407, 139);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(108, 51);
            btnRemove.TabIndex = 55;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = ContentAlignment.MiddleRight;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnAddtoCart_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bin.png");
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Transparent;
            lblPrice.Location = new Point(222, 139);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(22, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "0";
            lblPrice.Click += lblPrice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(173, 139);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 3;
            label1.Text = "Price:";
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
            lblName.Click += lblName_Click;
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
            imgView.Click += imgView_Click;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotGradientPanel1);
            Name = "CheckOut";
            Size = new Size(534, 215);
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private PictureBox imgView;
        private Label lblPrice;
        private Label label1;
        private Label lblName;
        private Button btnRemove;
        private ImageList imageList1;
        private Label label2;
        private NumericUpDown nmrcQuantity;
    }
}
