namespace Final.Forms
{
    partial class EditItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItems));
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            lblID = new Label();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            btnImportPhoto = new MaterialSkin.Controls.MaterialButton();
            panel3 = new Panel();
            imgView = new PictureBox();
            cbxStatus = new ComboBox();
            cbxType = new ComboBox();
            label1 = new Label();
            tbxItemName = new TextBox();
            tbxStock = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbx = new Label();
            tbxPrice = new TextBox();
            parrotGradientPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(btnDelete);
            parrotGradientPanel1.Controls.Add(lblID);
            parrotGradientPanel1.Controls.Add(btnUpdate);
            parrotGradientPanel1.Controls.Add(btnCancel);
            parrotGradientPanel1.Controls.Add(btnImportPhoto);
            parrotGradientPanel1.Controls.Add(panel3);
            parrotGradientPanel1.Controls.Add(cbxStatus);
            parrotGradientPanel1.Controls.Add(cbxType);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Controls.Add(tbxItemName);
            parrotGradientPanel1.Controls.Add(tbxStock);
            parrotGradientPanel1.Controls.Add(label4);
            parrotGradientPanel1.Controls.Add(label3);
            parrotGradientPanel1.Controls.Add(label2);
            parrotGradientPanel1.Controls.Add(tbx);
            parrotGradientPanel1.Controls.Add(tbxPrice);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(376, 500);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 1;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(148, 431);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Location = new Point(0, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 20);
            lblID.TabIndex = 37;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(30, 431);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(77, 36);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(274, 431);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnImportPhoto
            // 
            btnImportPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnImportPhoto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImportPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImportPhoto.Depth = 0;
            btnImportPhoto.HighEmphasis = true;
            btnImportPhoto.Icon = null;
            btnImportPhoto.Location = new Point(129, 140);
            btnImportPhoto.Margin = new Padding(4, 6, 4, 6);
            btnImportPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            btnImportPhoto.Name = "btnImportPhoto";
            btnImportPhoto.NoAccentTextColor = Color.Empty;
            btnImportPhoto.Size = new Size(129, 36);
            btnImportPhoto.TabIndex = 33;
            btnImportPhoto.Text = "IMPORT PHOTO";
            btnImportPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImportPhoto.UseAccentColor = false;
            btnImportPhoto.UseVisualStyleBackColor = true;
            btnImportPhoto.Click += btnImportPhoto_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(imgView);
            panel3.Location = new Point(131, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(125, 103);
            panel3.TabIndex = 32;
            // 
            // imgView
            // 
            imgView.Dock = DockStyle.Fill;
            imgView.Image = (Image)resources.GetObject("imgView.Image");
            imgView.Location = new Point(0, 0);
            imgView.Name = "imgView";
            imgView.Size = new Size(125, 103);
            imgView.SizeMode = PictureBoxSizeMode.Zoom;
            imgView.TabIndex = 0;
            imgView.TabStop = false;
            imgView.Click += imgView_Click;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Available", "Low in Stocks", "Not Available" });
            cbxStatus.Location = new Point(148, 367);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(161, 36);
            cbxStatus.TabIndex = 31;
            // 
            // cbxType
            // 
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Dog Food", "Cat Food", "Pig Food", "Fish Fod", "Cow Food", "Chicken Food" });
            cbxType.Location = new Point(148, 325);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(161, 36);
            cbxType.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(73, 370);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 29;
            label1.Text = "Status:";
            // 
            // tbxItemName
            // 
            tbxItemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxItemName.Location = new Point(148, 205);
            tbxItemName.Name = "tbxItemName";
            tbxItemName.Size = new Size(161, 34);
            tbxItemName.TabIndex = 23;
            // 
            // tbxStock
            // 
            tbxStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxStock.Location = new Point(148, 245);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(161, 34);
            tbxStock.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(85, 333);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 28;
            label4.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(78, 248);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 24;
            label3.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(30, 205);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 22;
            label2.Text = "Item Name:";
            // 
            // tbx
            // 
            tbx.AutoSize = true;
            tbx.BackColor = Color.Transparent;
            tbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx.ForeColor = Color.Transparent;
            tbx.Location = new Point(84, 288);
            tbx.Name = "tbx";
            tbx.Size = new Size(58, 28);
            tbx.TabIndex = 26;
            tbx.Text = "Price:";
            // 
            // tbxPrice
            // 
            tbxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPrice.Location = new Point(148, 285);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(161, 34);
            tbxPrice.TabIndex = 27;
            // 
            // EditItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 500);
            Controls.Add(parrotGradientPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditItems";
            StartPosition = FormStartPosition.CenterScreen;
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnImportPhoto;
        private Panel panel3;
        private PictureBox imgView;
        private ComboBox cbxStatus;
        private ComboBox cbxType;
        private Label label1;
        private TextBox tbxItemName;
        private TextBox tbxStock;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label tbx;
        private TextBox tbxPrice;
        private Label lblID;
        private MaterialSkin.Controls.MaterialButton btnDelete;
    }
}