﻿namespace Final
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            imgView = new PictureBox();
            btnAddtoCart = new Button();
            lblPrice = new Label();
            lblQty = new Label();
            lblName = new Label();
            label2 = new Label();
            label3 = new Label();
            imageList1 = new ImageList(components);
            parrotGradientPanel1.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(materialCard1);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(239, 230);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 3;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(imgView);
            materialCard1.Controls.Add(btnAddtoCart);
            materialCard1.Controls.Add(lblPrice);
            materialCard1.Controls.Add(lblQty);
            materialCard1.Controls.Add(lblName);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(label3);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(239, 230);
            materialCard1.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 1;
            label1.Text = "Price:";
            // 
            // imgView
            // 
            imgView.BackColor = SystemColors.AppWorkspace;
            imgView.Location = new Point(99, 3);
            imgView.Name = "imgView";
            imgView.Size = new Size(125, 103);
            imgView.SizeMode = PictureBoxSizeMode.StretchImage;
            imgView.TabIndex = 0;
            imgView.TabStop = false;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddtoCart.Location = new Point(116, 179);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(108, 48);
            btnAddtoCart.TabIndex = 59;
            btnAddtoCart.Text = "ADD TO\r\n CART";
            btnAddtoCart.UseVisualStyleBackColor = true;
            btnAddtoCart.Click += btnAddtoCart_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(3, 42);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 28);
            lblPrice.TabIndex = 58;
            lblPrice.Text = "pesos";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.BackColor = Color.Transparent;
            lblQty.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.ForeColor = Color.Black;
            lblQty.Location = new Point(69, 136);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(37, 23);
            lblQty.TabIndex = 57;
            lblQty.Text = "qty";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(3, 113);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 23);
            lblName.TabIndex = 56;
            lblName.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 136);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 2;
            label2.Text = "In Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "checkout.png");
            imageList1.Images.SetKeyName(1, "shopping-cart.png");
            // 
            // ItemsShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotGradientPanel1);
            Name = "ItemsShop";
            Size = new Size(239, 230);
            parrotGradientPanel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox imgView;
        private ImageList imageList1;
        private Label lblPrice;
        private Label lblQty;
        private Label lblName;
        private Button button2;
        private Button btnAddtoCart;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
