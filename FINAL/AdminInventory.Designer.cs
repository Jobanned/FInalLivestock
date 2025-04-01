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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInventory));
            panel1 = new Panel();
            cbxStatus = new ComboBox();
            cbxType = new ComboBox();
            btnImportPhoto = new MaterialSkin.Controls.MaterialButton();
            panel3 = new Panel();
            imgView = new PictureBox();
            label1 = new Label();
            tbxItemName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            tbxPrice = new TextBox();
            tbx = new Label();
            label3 = new Label();
            tbxStock = new TextBox();
            panel2 = new Panel();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxStatus);
            panel1.Controls.Add(cbxType);
            panel1.Controls.Add(btnImportPhoto);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbxItemName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbxPrice);
            panel1.Controls.Add(tbx);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbxStock);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 367);
            panel1.TabIndex = 0;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Available", "Low in Stocks", "Not Available" });
            cbxStatus.Location = new Point(157, 303);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(161, 36);
            cbxStatus.TabIndex = 21;
            // 
            // cbxType
            // 
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Pig Feed", "ChickenFeed", "Cow Feed", "Fish Feed", "Sheep Feed", "Horse Feed", "Bird Feed", "Dog Feed", "Cat Feed" });
            cbxType.Location = new Point(157, 261);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(161, 36);
            cbxType.TabIndex = 20;
            // 
            // btnImportPhoto
            // 
            btnImportPhoto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImportPhoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImportPhoto.Depth = 0;
            btnImportPhoto.HighEmphasis = true;
            btnImportPhoto.Icon = null;
            btnImportPhoto.Location = new Point(245, 39);
            btnImportPhoto.Margin = new Padding(4, 6, 4, 6);
            btnImportPhoto.MouseState = MaterialSkin.MouseState.HOVER;
            btnImportPhoto.Name = "btnImportPhoto";
            btnImportPhoto.NoAccentTextColor = Color.Empty;
            btnImportPhoto.Size = new Size(129, 36);
            btnImportPhoto.TabIndex = 19;
            btnImportPhoto.Text = "IMPORT PHOTO";
            btnImportPhoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImportPhoto.UseAccentColor = false;
            btnImportPhoto.UseVisualStyleBackColor = true;
            btnImportPhoto.Click += btnImportPhoto_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(imgView);
            panel3.Location = new Point(125, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(113, 110);
            panel3.TabIndex = 18;
            // 
            // imgView
            // 
            imgView.Dock = DockStyle.Fill;
            imgView.Image = (Image)resources.GetObject("imgView.Image");
            imgView.Location = new Point(0, 0);
            imgView.Name = "imgView";
            imgView.Size = new Size(113, 110);
            imgView.SizeMode = PictureBoxSizeMode.Zoom;
            imgView.TabIndex = 0;
            imgView.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 306);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 16;
            label1.Text = "Status:";
            // 
            // tbxItemName
            // 
            tbxItemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxItemName.Location = new Point(157, 141);
            tbxItemName.Name = "tbxItemName";
            tbxItemName.Size = new Size(161, 34);
            tbxItemName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 269);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 14;
            label4.Text = "Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 141);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 8;
            label2.Text = "Item Name:";
            // 
            // tbxPrice
            // 
            tbxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPrice.Location = new Point(157, 221);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(161, 34);
            tbxPrice.TabIndex = 13;
            // 
            // tbx
            // 
            tbx.AutoSize = true;
            tbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx.Location = new Point(93, 224);
            tbx.Name = "tbx";
            tbx.Size = new Size(58, 28);
            tbx.TabIndex = 12;
            tbx.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 184);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 10;
            label3.Text = "Stock:";
            // 
            // tbxStock
            // 
            tbxStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxStock.Location = new Point(157, 181);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(161, 34);
            tbxStock.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(400, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 367);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(410, 287);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(66, 36);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(284, 287);
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(565, 254);
            dataGridView1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(163, 287);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(77, 36);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(46, 287);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AdminInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminInventory";
            Size = new Size(965, 367);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnImportPhoto;
        private Panel panel3;
        private Label label1;
        private TextBox tbxItemName;
        private Label label4;
        private Label label2;
        private TextBox tbxPrice;
        private Label tbx;
        private Label label3;
        private TextBox tbxStock;
        private ComboBox cbxStatus;
        private ComboBox cbxType;
        private PictureBox imgView;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnClear;
    }
}
