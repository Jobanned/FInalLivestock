namespace FINAL
{
    partial class AccountInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfo));
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnLogin = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtbxPassword = new TextBox();
            txtbxEmail = new TextBox();
            txtbxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            lnklblChangePassword = new LinkLabel();
            lnklblChangeEmail = new LinkLabel();
            lnklblChangeUsername = new LinkLabel();
            btnConfrim = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Symbol", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(7, 250, 96);
            bigLabel1.Location = new Point(140, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(380, 50);
            bigLabel1.TabIndex = 19;
            bigLabel1.Text = "Account Information";
            // 
            // btnLogin
            // 
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(370, 347);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.FromArgb(140, 200, 148);
            btnLogin.Size = new Size(133, 46);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 40;
            btnLogin.Text = "Log Out";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 308);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // txtbxPassword
            // 
            txtbxPassword.BorderStyle = BorderStyle.None;
            txtbxPassword.Location = new Point(60, 308);
            txtbxPassword.Multiline = true;
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '*';
            txtbxPassword.Size = new Size(280, 36);
            txtbxPassword.TabIndex = 36;
            // 
            // txtbxEmail
            // 
            txtbxEmail.BorderStyle = BorderStyle.None;
            txtbxEmail.Location = new Point(60, 217);
            txtbxEmail.Multiline = true;
            txtbxEmail.Name = "txtbxEmail";
            txtbxEmail.Size = new Size(280, 36);
            txtbxEmail.TabIndex = 35;
            // 
            // txtbxUsername
            // 
            txtbxUsername.BorderStyle = BorderStyle.None;
            txtbxUsername.Location = new Point(60, 119);
            txtbxUsername.Multiline = true;
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(280, 36);
            txtbxUsername.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 280);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 33;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 189);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 32;
            label2.Text = "Email Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 91);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 31;
            label1.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(52, 84, 52);
            label4.Location = new Point(10, 50);
            label4.Name = "label4";
            label4.Size = new Size(111, 31);
            label4.TabIndex = 42;
            label4.Text = "GENERAL";
            // 
            // lnklblChangePassword
            // 
            lnklblChangePassword.AutoSize = true;
            lnklblChangePassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnklblChangePassword.LinkColor = Color.FromArgb(7, 250, 96);
            lnklblChangePassword.Location = new Point(188, 347);
            lnklblChangePassword.Name = "lnklblChangePassword";
            lnklblChangePassword.Size = new Size(152, 25);
            lnklblChangePassword.TabIndex = 43;
            lnklblChangePassword.TabStop = true;
            lnklblChangePassword.Text = "Change Password";
            // 
            // lnklblChangeEmail
            // 
            lnklblChangeEmail.AutoSize = true;
            lnklblChangeEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnklblChangeEmail.LinkColor = Color.FromArgb(7, 250, 96);
            lnklblChangeEmail.Location = new Point(221, 256);
            lnklblChangeEmail.Name = "lnklblChangeEmail";
            lnklblChangeEmail.Size = new Size(119, 25);
            lnklblChangeEmail.TabIndex = 44;
            lnklblChangeEmail.TabStop = true;
            lnklblChangeEmail.Text = "Change Email";
            // 
            // lnklblChangeUsername
            // 
            lnklblChangeUsername.AutoSize = true;
            lnklblChangeUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnklblChangeUsername.LinkColor = Color.FromArgb(7, 250, 96);
            lnklblChangeUsername.Location = new Point(184, 158);
            lnklblChangeUsername.Name = "lnklblChangeUsername";
            lnklblChangeUsername.Size = new Size(156, 25);
            lnklblChangeUsername.TabIndex = 45;
            lnklblChangeUsername.TabStop = true;
            lnklblChangeUsername.Text = "Change Username";
            // 
            // btnConfrim
            // 
            btnConfrim.BorderColor = Color.FromArgb(220, 223, 230);
            btnConfrim.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnConfrim.DangerColor = Color.FromArgb(245, 108, 108);
            btnConfrim.DefaultColor = Color.FromArgb(255, 255, 255);
            btnConfrim.Font = new Font("Segoe UI", 12F);
            btnConfrim.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnConfrim.InfoColor = Color.FromArgb(144, 147, 153);
            btnConfrim.Location = new Point(509, 347);
            btnConfrim.Name = "btnConfrim";
            btnConfrim.PrimaryColor = Color.FromArgb(140, 200, 148);
            btnConfrim.Size = new Size(133, 46);
            btnConfrim.SuccessColor = Color.FromArgb(103, 194, 58);
            btnConfrim.TabIndex = 46;
            btnConfrim.Text = "Confirm";
            btnConfrim.TextColor = Color.White;
            btnConfrim.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // AccountInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 84, 52);
            Controls.Add(btnConfrim);
            Controls.Add(lnklblChangeUsername);
            Controls.Add(lnklblChangeEmail);
            Controls.Add(lnklblChangePassword);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtbxPassword);
            Controls.Add(txtbxEmail);
            Controls.Add(txtbxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bigLabel1);
            Name = "AccountInfo";
            Size = new Size(645, 402);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopeRoundButton btnLogin;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtbxPassword;
        private TextBox txtbxEmail;
        private TextBox txtbxUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private LinkLabel lnklblChangePassword;
        private LinkLabel lnklblChangeEmail;
        private LinkLabel lnklblChangeUsername;
        private ReaLTaiizor.Controls.HopeRoundButton btnConfrim;
    }
}
