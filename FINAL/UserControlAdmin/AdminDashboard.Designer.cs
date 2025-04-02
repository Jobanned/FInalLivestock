namespace Final
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            lblTotalIncome = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            lblTodayIncome = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            lblCustomer = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(materialCard3);
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(materialCard1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 157);
            panel1.TabIndex = 1;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lblTotalIncome);
            materialCard3.Controls.Add(pictureBox1);
            materialCard3.Controls.Add(label3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(597, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(219, 125);
            materialCard3.TabIndex = 2;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.Location = new Point(178, 83);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(24, 28);
            lblTotalIncome.TabIndex = 5;
            lblTotalIncome.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 50);
            label3.TabIndex = 4;
            label3.Text = "Total\n       Income";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblTodayIncome);
            materialCard2.Controls.Add(pictureBox3);
            materialCard2.Controls.Add(label2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(350, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(219, 125);
            materialCard2.TabIndex = 1;
            // 
            // lblTodayIncome
            // 
            lblTodayIncome.AutoSize = true;
            lblTodayIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayIncome.Location = new Point(178, 83);
            lblTodayIncome.Name = "lblTodayIncome";
            lblTodayIncome.Size = new Size(24, 28);
            lblTodayIncome.TabIndex = 4;
            lblTodayIncome.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(81, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 50);
            label2.TabIndex = 3;
            label2.Text = "Today's\r\n       Income";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblCustomer);
            materialCard1.Controls.Add(pictureBox2);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(103, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(219, 125);
            materialCard1.TabIndex = 0;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(169, 80);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(24, 28);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "0";
            lblCustomer.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 50);
            label1.TabIndex = 2;
            label1.Text = "Number of \r\n     Customer";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Size = new Size(957, 367);
            panel1.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private Label lblTotalIncome;
        private PictureBox pictureBox1;
        private Label label3;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private Label lblTodayIncome;
        private PictureBox pictureBox3;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label lblCustomer;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
