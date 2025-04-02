namespace Final
{
    partial class AdminSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSales));
            panel1 = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnDayIncome = new MaterialSkin.Controls.MaterialFloatingActionButton();
            label1 = new Label();
            btnWeekIncome = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            label2 = new Label();
            btnMonthIncome = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            btnYearIncome = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            label4 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnYearIncome);
            panel1.Controls.Add(materialCard4);
            panel1.Controls.Add(btnMonthIncome);
            panel1.Controls.Add(materialCard3);
            panel1.Controls.Add(btnWeekIncome);
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(btnDayIncome);
            panel1.Controls.Add(materialCard1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 157);
            panel1.TabIndex = 2;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(44, 18);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(180, 125);
            materialCard1.TabIndex = 0;
            // 
            // btnDayIncome
            // 
            btnDayIncome.Depth = 0;
            btnDayIncome.FlatStyle = FlatStyle.Popup;
            btnDayIncome.ForeColor = Color.Transparent;
            btnDayIncome.Icon = (Image)resources.GetObject("btnDayIncome.Icon");
            btnDayIncome.ImageKey = "tap.png";
            btnDayIncome.ImageList = imageList1;
            btnDayIncome.Location = new Point(194, 54);
            btnDayIncome.MouseState = MaterialSkin.MouseState.HOVER;
            btnDayIncome.Name = "btnDayIncome";
            btnDayIncome.Size = new Size(56, 56);
            btnDayIncome.TabIndex = 1;
            btnDayIncome.Text = "materialFloatingActionButton1";
            btnDayIncome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 50);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Today's Income";
            // 
            // btnWeekIncome
            // 
            btnWeekIncome.Depth = 0;
            btnWeekIncome.FlatStyle = FlatStyle.Popup;
            btnWeekIncome.Icon = (Image)resources.GetObject("btnWeekIncome.Icon");
            btnWeekIncome.Location = new Point(417, 54);
            btnWeekIncome.MouseState = MaterialSkin.MouseState.HOVER;
            btnWeekIncome.Name = "btnWeekIncome";
            btnWeekIncome.Size = new Size(56, 56);
            btnWeekIncome.TabIndex = 3;
            btnWeekIncome.Text = "materialFloatingActionButton2";
            btnWeekIncome.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(label2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(267, 18);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(180, 125);
            materialCard2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 36);
            label2.Name = "label2";
            label2.Size = new Size(108, 50);
            label2.TabIndex = 0;
            label2.Text = "This Week's \r\n  Income";
            // 
            // btnMonthIncome
            // 
            btnMonthIncome.Depth = 0;
            btnMonthIncome.FlatStyle = FlatStyle.Popup;
            btnMonthIncome.Icon = (Image)resources.GetObject("btnMonthIncome.Icon");
            btnMonthIncome.Location = new Point(640, 54);
            btnMonthIncome.MouseState = MaterialSkin.MouseState.HOVER;
            btnMonthIncome.Name = "btnMonthIncome";
            btnMonthIncome.Size = new Size(56, 56);
            btnMonthIncome.TabIndex = 5;
            btnMonthIncome.Text = "materialFloatingActionButton3";
            btnMonthIncome.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(label3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(490, 18);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(180, 125);
            materialCard3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 36);
            label3.Name = "label3";
            label3.Size = new Size(118, 50);
            label3.TabIndex = 0;
            label3.Text = "This Month's \r\n     Income";
            // 
            // btnYearIncome
            // 
            btnYearIncome.Depth = 0;
            btnYearIncome.FlatStyle = FlatStyle.Popup;
            btnYearIncome.Icon = (Image)resources.GetObject("btnYearIncome.Icon");
            btnYearIncome.Location = new Point(863, 54);
            btnYearIncome.MouseState = MaterialSkin.MouseState.HOVER;
            btnYearIncome.Name = "btnYearIncome";
            btnYearIncome.Size = new Size(56, 56);
            btnYearIncome.TabIndex = 7;
            btnYearIncome.Text = "materialFloatingActionButton4";
            btnYearIncome.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(label4);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(713, 18);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(180, 125);
            materialCard4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 36);
            label4.Name = "label4";
            label4.Size = new Size(97, 50);
            label4.TabIndex = 0;
            label4.Text = "This Year's \r\n     Income";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 210);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(957, 210);
            dataGridView1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "tap.png");
            // 
            // AdminSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminSales";
            Size = new Size(957, 367);
            panel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnDayIncome;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnYearIncome;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Label label4;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnMonthIncome;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label label3;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnWeekIncome;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private ImageList imageList1;
    }
}
