﻿namespace Final
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label5 = new Label();
            Exit = new Button();
            pictureBox3 = new PictureBox();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            chkbxShowPass = new CheckBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            lnklblForgotPass = new LinkLabel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            tbxPass = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            txtbxUser = new TextBox();
            panelWelcome = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(156, 188, 95);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 35);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(12, 7);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 61;
            label5.Text = "AgriFlow";
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(156, 188, 95);
            Exit.BackgroundImage = (Image)resources.GetObject("Exit.BackgroundImage");
            Exit.BackgroundImageLayout = ImageLayout.Zoom;
            Exit.Dock = DockStyle.Right;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = SystemColors.Control;
            Exit.Location = new Point(737, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(45, 35);
            Exit.TabIndex = 0;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(470, 516);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(122, 90, 73);
            parrotGradientPanel1.BottomRight = Color.FromArgb(156, 188, 95);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(chkbxShowPass);
            parrotGradientPanel1.Controls.Add(linkLabel1);
            parrotGradientPanel1.Controls.Add(label4);
            parrotGradientPanel1.Controls.Add(lnklblForgotPass);
            parrotGradientPanel1.Controls.Add(label2);
            parrotGradientPanel1.Controls.Add(pictureBox2);
            parrotGradientPanel1.Controls.Add(tbxPass);
            parrotGradientPanel1.Controls.Add(label3);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Controls.Add(pictureBox1);
            parrotGradientPanel1.Controls.Add(btnLogin);
            parrotGradientPanel1.Controls.Add(txtbxUser);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(312, 516);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 51;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(240, 231, 213);
            parrotGradientPanel1.TopRight = Color.FromArgb(156, 188, 95);
            // 
            // chkbxShowPass
            // 
            chkbxShowPass.AutoSize = true;
            chkbxShowPass.BackColor = Color.Transparent;
            chkbxShowPass.Location = new Point(65, 258);
            chkbxShowPass.Name = "chkbxShowPass";
            chkbxShowPass.Size = new Size(132, 24);
            chkbxShowPass.TabIndex = 65;
            chkbxShowPass.Text = "Show Password";
            chkbxShowPass.UseVisualStyleBackColor = false;
            chkbxShowPass.CheckedChanged += chkbxShowPass_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.FromArgb(255, 192, 192);
            linkLabel1.Location = new Point(102, 464);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 20);
            linkLabel1.TabIndex = 64;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create an Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(82, 444);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 63;
            label4.Text = "Dont have an Account?";
            // 
            // lnklblForgotPass
            // 
            lnklblForgotPass.AutoSize = true;
            lnklblForgotPass.BackColor = Color.Transparent;
            lnklblForgotPass.LinkColor = Color.FromArgb(255, 192, 192);
            lnklblForgotPass.Location = new Point(159, 285);
            lnklblForgotPass.Name = "lnklblForgotPass";
            lnklblForgotPass.Size = new Size(125, 20);
            lnklblForgotPass.TabIndex = 62;
            lnklblForgotPass.TabStop = true;
            lnklblForgotPass.Text = "Forgot Password?";
            lnklblForgotPass.LinkClicked += lnklblForgotPass_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(65, 193);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 60;
            label2.Text = "Password:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // tbxPass
            // 
            tbxPass.BorderStyle = BorderStyle.None;
            tbxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPass.Location = new Point(65, 221);
            tbxPass.Name = "tbxPass";
            tbxPass.PasswordChar = '•';
            tbxPass.Size = new Size(219, 27);
            tbxPass.TabIndex = 58;
            tbxPass.KeyDown += tbxPass_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(7, 250, 96);
            label3.Location = new Point(76, 23);
            label3.Name = "label3";
            label3.Size = new Size(178, 46);
            label3.TabIndex = 57;
            label3.Text = "Welcome!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(65, 116);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 55;
            label1.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(65, 362);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(199, 43);
            btnLogin.TabIndex = 53;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtbxUser
            // 
            txtbxUser.BorderStyle = BorderStyle.None;
            txtbxUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUser.Location = new Point(65, 144);
            txtbxUser.Name = "txtbxUser";
            txtbxUser.Size = new Size(219, 27);
            txtbxUser.TabIndex = 44;
            // 
            // panelWelcome
            // 
            panelWelcome.BackgroundImageLayout = ImageLayout.Stretch;
            panelWelcome.Controls.Add(parrotGradientPanel1);
            panelWelcome.Dock = DockStyle.Fill;
            panelWelcome.ForeColor = Color.Transparent;
            panelWelcome.Location = new Point(470, 35);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(312, 516);
            panelWelcome.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(782, 551);
            Controls.Add(panelWelcome);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgriFlow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelWelcome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Exit;
        private PictureBox pictureBox3;
        private Label label5;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private CheckBox chkbxShowPass;
        private LinkLabel linkLabel1;
        private Label label4;
        private LinkLabel lnklblForgotPass;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox tbxPass;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private TextBox txtbxUser;
        private Panel panelWelcome;
    }
}
