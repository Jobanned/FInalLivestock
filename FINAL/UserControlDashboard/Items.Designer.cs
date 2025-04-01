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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            panel1 = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblName = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            btn = new Button();
            ptxItem = new PictureBox();
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptxItem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(materialCard1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 288);
            panel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblName);
            materialCard1.Controls.Add(lblQuantity);
            materialCard1.Controls.Add(lblPrice);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(button1);
            materialCard1.Controls.Add(btn);
            materialCard1.Controls.Add(ptxItem);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(279, 260);
            materialCard1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(75, 151);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 25);
            lblName.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(29, 101);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(0, 25);
            lblQuantity.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(17, 37);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 25);
            lblPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 17);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 155);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(145, 208);
            button1.Name = "button1";
            button1.Size = new Size(51, 35);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.FlatStyle = FlatStyle.Flat;
            btn.Location = new Point(67, 208);
            btn.Name = "btn";
            btn.Size = new Size(51, 35);
            btn.TabIndex = 1;
            btn.UseVisualStyleBackColor = true;
            // 
            // ptxItem
            // 
            ptxItem.Image = (Image)resources.GetObject("ptxItem.Image");
            ptxItem.Location = new Point(118, 17);
            ptxItem.Name = "ptxItem";
            ptxItem.Size = new Size(144, 126);
            ptxItem.SizeMode = PictureBoxSizeMode.Zoom;
            ptxItem.TabIndex = 0;
            ptxItem.TabStop = false;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Items";
            Size = new Size(307, 288);
            panel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptxItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Button btn;
        private PictureBox ptxItem;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblName;
        private Label lblQuantity;
        private Label lblPrice;
    }
}
