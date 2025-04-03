namespace Final
{
    partial class Items
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
            panel1 = new Panel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblQuantity = new Label();
            lblItemName = new Label();
            lblPrice = new Label();
            btnEdit = new MaterialSkin.Controls.MaterialButton();
            imgView = new PictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            panel1.SuspendLayout();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(parrotGradientPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 288);
            panel1.TabIndex = 0;
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
            parrotGradientPanel1.Size = new Size(307, 288);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 2;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 195);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 13;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 167);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 12;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 139);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 11;
            label1.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(131, 195);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(95, 28);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.Black;
            lblItemName.Location = new Point(131, 167);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(68, 28);
            lblItemName.TabIndex = 7;
            lblItemName.Text = "Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(131, 139);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 28);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = null;
            btnEdit.Location = new Point(214, 232);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(64, 36);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // imgView
            // 
            imgView.BackColor = SystemColors.AppWorkspace;
            imgView.Location = new Point(89, 17);
            imgView.Name = "imgView";
            imgView.Size = new Size(125, 103);
            imgView.SizeMode = PictureBoxSizeMode.Zoom;
            imgView.TabIndex = 0;
            imgView.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(imgView);
            materialCard1.Controls.Add(btnEdit);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(lblPrice);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(lblItemName);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(lblQuantity);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(307, 288);
            materialCard1.TabIndex = 14;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Items";
            Size = new Size(307, 288);
            panel1.ResumeLayout(false);
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgView).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private PictureBox imgView;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private Label lblQuantity;
        private Label lblItemName;
        private Label lblPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
