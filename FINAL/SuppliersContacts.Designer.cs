namespace Final
{
    partial class SuppliersContacts
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            tbxPrice = new TextBox();
            tbx = new Label();
            tbxStock = new TextBox();
            label3 = new Label();
            tbxItemName = new TextBox();
            label2 = new Label();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 188);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 1;
            label1.Text = "List of Suppliers";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(957, 149);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbxPrice);
            panel2.Controls.Add(tbx);
            panel2.Controls.Add(tbxStock);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbxItemName);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 188);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 179);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(344, 97);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 6;
            label4.Text = "Status:";
            // 
            // tbxPrice
            // 
            tbxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPrice.Location = new Point(419, 42);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(161, 34);
            tbxPrice.TabIndex = 5;
            // 
            // tbx
            // 
            tbx.AutoSize = true;
            tbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx.Location = new Point(355, 42);
            tbx.Name = "tbx";
            tbx.Size = new Size(58, 28);
            tbx.TabIndex = 4;
            tbx.Text = "Price:";
            // 
            // tbxStock
            // 
            tbxStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxStock.Location = new Point(155, 94);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(161, 34);
            tbxStock.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 97);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:";
            // 
            // tbxItemName
            // 
            tbxItemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxItemName.Location = new Point(155, 42);
            tbxItemName.Name = "tbxItemName";
            tbxItemName.Size = new Size(161, 34);
            tbxItemName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 0;
            label2.Text = "Supplier Name:";
            // 
            // btnClear
            // 
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(813, 97);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(77, 36);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(695, 97);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(77, 36);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(813, 44);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(77, 36);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(695, 44);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(77, 36);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(419, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 33);
            comboBox1.TabIndex = 30;
            // 
            // SuppliersContacts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SuppliersContacts";
            Size = new Size(957, 367);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox tbxStock;
        private Label label3;
        private TextBox tbxItemName;
        private Label label2;
        private Label label4;
        private TextBox tbxPrice;
        private Label tbx;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private ComboBox comboBox1;
    }
}
