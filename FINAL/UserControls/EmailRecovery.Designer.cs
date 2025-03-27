namespace FINAL
{
    partial class EmailRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailRecovery));
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnContinue = new Button();
            lnklblUsername = new LinkLabel();
            txtbxEmail = new TextBox();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(pictureBox5);
            parrotGradientPanel1.Controls.Add(label3);
            parrotGradientPanel1.Controls.Add(label2);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Controls.Add(btnContinue);
            parrotGradientPanel1.Controls.Add(lnklblUsername);
            parrotGradientPanel1.Controls.Add(txtbxEmail);
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
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 214);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 58;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(7, 250, 96);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(386, 46);
            label3.TabIndex = 57;
            label3.Text = "Forgot your Password?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(19, 111);
            label2.Name = "label2";
            label2.Size = new Size(275, 40);
            label2.TabIndex = 56;
            label2.Text = "Please enter the email that you want to\r\nreset the password.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(69, 191);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 55;
            label1.Text = "Email Address:";
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Transparent;
            btnContinue.FlatAppearance.BorderColor = Color.White;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.ForeColor = Color.Transparent;
            btnContinue.Location = new Point(81, 356);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(199, 43);
            btnContinue.TabIndex = 53;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click_1;
            // 
            // lnklblUsername
            // 
            lnklblUsername.AutoSize = true;
            lnklblUsername.BackColor = Color.Transparent;
            lnklblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnklblUsername.LinkColor = Color.FromArgb(7, 250, 96);
            lnklblUsername.Location = new Point(118, 402);
            lnklblUsername.Name = "lnklblUsername";
            lnklblUsername.Size = new Size(128, 20);
            lnklblUsername.TabIndex = 51;
            lnklblUsername.TabStop = true;
            lnklblUsername.Text = "Back to Username";
            lnklblUsername.LinkClicked += lnklblUsername_LinkClicked;
            // 
            // txtbxEmail
            // 
            txtbxEmail.BorderStyle = BorderStyle.None;
            txtbxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxEmail.Location = new Point(69, 214);
            txtbxEmail.Multiline = true;
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(252, 36);
            txtbxEmail.TabIndex = 44;
            // 
            // EmailRecovery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(parrotGradientPanel1);
            DoubleBuffered = true;
            Name = "EmailRecovery";
            Size = new Size(384, 499);
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnContinue;
        private TextBox txtbxEmail;
        private LinkLabel lnklblUsername;
        private PictureBox pictureBox5;
    }
}
