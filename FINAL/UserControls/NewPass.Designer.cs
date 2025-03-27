namespace FINAL
{
    partial class NewPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPass));
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            chxbxShowPass = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtbxNewPass = new TextBox();
            label4 = new Label();
            txtbxPass = new TextBox();
            label3 = new Label();
            btnContinue = new Button();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(chxbxShowPass);
            parrotGradientPanel1.Controls.Add(pictureBox1);
            parrotGradientPanel1.Controls.Add(pictureBox2);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Controls.Add(txtbxNewPass);
            parrotGradientPanel1.Controls.Add(label4);
            parrotGradientPanel1.Controls.Add(txtbxPass);
            parrotGradientPanel1.Controls.Add(label3);
            parrotGradientPanel1.Controls.Add(btnContinue);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(384, 499);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 51;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // chxbxShowPass
            // 
            chxbxShowPass.AutoSize = true;
            chxbxShowPass.BackColor = Color.Transparent;
            chxbxShowPass.Location = new Point(79, 283);
            chxbxShowPass.Name = "chxbxShowPass";
            chxbxShowPass.Size = new Size(132, 24);
            chxbxShowPass.TabIndex = 64;
            chxbxShowPass.Text = "Show Password";
            chxbxShowPass.UseVisualStyleBackColor = false;
            chxbxShowPass.CheckedChanged += chxbxShowPass_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 245);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(78, 229);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 61;
            label1.Text = "Confirm Password:";
            // 
            // txtbxNewPass
            // 
            txtbxNewPass.Font = new Font("Segoe UI", 12F);
            txtbxNewPass.Location = new Point(78, 254);
            txtbxNewPass.Name = "txtbxNewPass";
            txtbxNewPass.PasswordChar = '*';
            txtbxNewPass.Size = new Size(242, 34);
            txtbxNewPass.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(78, 150);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 59;
            label4.Text = "Set Password:";
            // 
            // txtbxPass
            // 
            txtbxPass.Font = new Font("Segoe UI", 12F);
            txtbxPass.Location = new Point(78, 175);
            txtbxPass.Name = "txtbxPass";
            txtbxPass.PasswordChar = '*';
            txtbxPass.Size = new Size(242, 34);
            txtbxPass.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(7, 250, 96);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(376, 41);
            label3.TabIndex = 57;
            label3.Text = "Enter your New Password\r\n";
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Transparent;
            btnContinue.FlatAppearance.BorderColor = Color.White;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.ForeColor = Color.Transparent;
            btnContinue.Location = new Point(78, 389);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(199, 43);
            btnContinue.TabIndex = 53;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click_1;
            // 
            // NewPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 84, 52);
            Controls.Add(parrotGradientPanel1);
            Name = "NewPass";
            Size = new Size(384, 499);
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label3;
        private Button btnContinue;
        private Label label4;
        private TextBox txtbxPass;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtbxNewPass;
        private PictureBox pictureBox1;
        private CheckBox chxbxShowPass;
    }
}
