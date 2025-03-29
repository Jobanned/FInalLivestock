namespace Final
{
    partial class OTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTP));
            panel1 = new Panel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            btnSend = new Button();
            label6 = new Label();
            label4 = new Label();
            lnklblResend = new LinkLabel();
            otp6 = new TextBox();
            otp5 = new TextBox();
            otp4 = new TextBox();
            otp3 = new TextBox();
            otp2 = new TextBox();
            pictureBox6 = new PictureBox();
            otp1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnContinue = new Button();
            lnklblLogin = new LinkLabel();
            tbxEmail = new TextBox();
            timerOTP = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(parrotGradientPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 469);
            panel1.TabIndex = 0;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(btnSend);
            parrotGradientPanel1.Controls.Add(label6);
            parrotGradientPanel1.Controls.Add(label4);
            parrotGradientPanel1.Controls.Add(lnklblResend);
            parrotGradientPanel1.Controls.Add(otp6);
            parrotGradientPanel1.Controls.Add(otp5);
            parrotGradientPanel1.Controls.Add(otp4);
            parrotGradientPanel1.Controls.Add(otp3);
            parrotGradientPanel1.Controls.Add(otp2);
            parrotGradientPanel1.Controls.Add(pictureBox6);
            parrotGradientPanel1.Controls.Add(otp1);
            parrotGradientPanel1.Controls.Add(label3);
            parrotGradientPanel1.Controls.Add(label2);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Controls.Add(btnContinue);
            parrotGradientPanel1.Controls.Add(lnklblLogin);
            parrotGradientPanel1.Controls.Add(tbxEmail);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(764, 469);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 57;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Transparent;
            btnSend.FlatAppearance.BorderColor = Color.White;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.ForeColor = Color.Transparent;
            btnSend.Location = new Point(584, 153);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(88, 36);
            btnSend.TabIndex = 85;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(7, 250, 96);
            label6.Location = new Point(259, 229);
            label6.Name = "label6";
            label6.Size = new Size(280, 46);
            label6.TabIndex = 83;
            label6.Text = "OTP Verification";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(166, 192);
            label4.Name = "label4";
            label4.Size = new Size(228, 20);
            label4.TabIndex = 82;
            label4.Text = "Didn't receive code verification?";
            // 
            // lnklblResend
            // 
            lnklblResend.AutoSize = true;
            lnklblResend.BackColor = Color.Transparent;
            lnklblResend.LinkColor = Color.FromArgb(7, 250, 96);
            lnklblResend.Location = new Point(399, 192);
            lnklblResend.Name = "lnklblResend";
            lnklblResend.Size = new Size(80, 20);
            lnklblResend.TabIndex = 81;
            lnklblResend.TabStop = true;
            lnklblResend.Text = "Click Here!";
            lnklblResend.LinkClicked += lnklblResend_LinkClicked;
            // 
            // otp6
            // 
            otp6.BorderStyle = BorderStyle.None;
            otp6.Font = new Font("Segoe UI", 24F);
            otp6.Location = new Point(522, 278);
            otp6.Multiline = true;
            otp6.Name = "otp6";
            otp6.Size = new Size(56, 56);
            otp6.TabIndex = 80;
            otp6.TextAlign = HorizontalAlignment.Center;
            // 
            // otp5
            // 
            otp5.BorderStyle = BorderStyle.None;
            otp5.Font = new Font("Segoe UI", 24F);
            otp5.Location = new Point(460, 278);
            otp5.Multiline = true;
            otp5.Name = "otp5";
            otp5.Size = new Size(56, 56);
            otp5.TabIndex = 79;
            otp5.TextAlign = HorizontalAlignment.Center;
            // 
            // otp4
            // 
            otp4.BorderStyle = BorderStyle.None;
            otp4.Font = new Font("Segoe UI", 24F);
            otp4.Location = new Point(398, 278);
            otp4.Multiline = true;
            otp4.Name = "otp4";
            otp4.Size = new Size(56, 56);
            otp4.TabIndex = 78;
            otp4.TextAlign = HorizontalAlignment.Center;
            // 
            // otp3
            // 
            otp3.BorderStyle = BorderStyle.None;
            otp3.Font = new Font("Segoe UI", 24F);
            otp3.Location = new Point(336, 278);
            otp3.Multiline = true;
            otp3.Name = "otp3";
            otp3.Size = new Size(56, 56);
            otp3.TabIndex = 77;
            otp3.TextAlign = HorizontalAlignment.Center;
            // 
            // otp2
            // 
            otp2.BorderStyle = BorderStyle.None;
            otp2.Font = new Font("Segoe UI", 24F);
            otp2.Location = new Point(274, 278);
            otp2.Multiline = true;
            otp2.Name = "otp2";
            otp2.Size = new Size(56, 56);
            otp2.TabIndex = 76;
            otp2.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(116, 153);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 75;
            pictureBox6.TabStop = false;
            // 
            // otp1
            // 
            otp1.BorderStyle = BorderStyle.None;
            otp1.Font = new Font("Segoe UI", 24F);
            otp1.Location = new Point(212, 278);
            otp1.Multiline = true;
            otp1.Name = "otp1";
            otp1.Size = new Size(56, 56);
            otp1.TabIndex = 68;
            otp1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(7, 250, 96);
            label3.Location = new Point(226, 9);
            label3.Name = "label3";
            label3.Size = new Size(303, 46);
            label3.TabIndex = 57;
            label3.Text = "Forgot Password?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(153, 69);
            label2.Name = "label2";
            label2.Size = new Size(452, 20);
            label2.TabIndex = 56;
            label2.Text = "Forgot your password? Don't worry, we can reset your password!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(166, 130);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 55;
            label1.Text = "Enter your Email:";
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Transparent;
            btnContinue.FlatAppearance.BorderColor = Color.White;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.ForeColor = Color.Transparent;
            btnContinue.Location = new Point(287, 369);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(199, 43);
            btnContinue.TabIndex = 53;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // lnklblLogin
            // 
            lnklblLogin.AutoSize = true;
            lnklblLogin.BackColor = Color.Transparent;
            lnklblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnklblLogin.LinkColor = Color.FromArgb(7, 250, 96);
            lnklblLogin.Location = new Point(336, 424);
            lnklblLogin.Name = "lnklblLogin";
            lnklblLogin.Size = new Size(99, 20);
            lnklblLogin.TabIndex = 51;
            lnklblLogin.TabStop = true;
            lnklblLogin.Text = "Back to Login";
            lnklblLogin.LinkClicked += lnklblLogin_LinkClicked;
            // 
            // tbxEmail
            // 
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEmail.Location = new Point(166, 153);
            tbxEmail.Multiline = true;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(412, 36);
            tbxEmail.TabIndex = 44;
            // 
            // timerOTP
            // 
            timerOTP.Tick += timerOTP_Tick;
            // 
            // OTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OTP";
            Size = new Size(764, 469);
            panel1.ResumeLayout(false);
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label6;
        private Label label4;
        private LinkLabel lnklblResend;
        private TextBox otp6;
        private TextBox otp5;
        private TextBox otp4;
        private TextBox otp3;
        private TextBox otp2;
        private PictureBox pictureBox6;
        private TextBox otp1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnContinue;
        private LinkLabel lnklblLogin;
        private TextBox tbxEmail;
        private System.Windows.Forms.Timer timerOTP;
        private Button btnSend;
    }
}
