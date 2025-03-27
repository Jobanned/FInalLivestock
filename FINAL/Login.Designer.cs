namespace Final
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
            Exit = new Button();
            panel2 = new Panel();
            label4 = new Label();
            lnklblForgotPass = new LinkLabel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            txtbxPass = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lnklblCreateAcc = new LinkLabel();
            label1 = new Label();
            txtbxUser = new TextBox();
            btnLogin = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(156, 188, 95);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 47);
            panel1.TabIndex = 0;
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
            Exit.Size = new Size(45, 47);
            Exit.TabIndex = 0;
            Exit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lnklblForgotPass);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtbxPass);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lnklblCreateAcc);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtbxUser);
            panel2.Controls.Add(btnLogin);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(185, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 404);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(82, 350);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 10;
            label4.Text = "Dont have an Account?";
            // 
            // lnklblForgotPass
            // 
            lnklblForgotPass.AutoSize = true;
            lnklblForgotPass.BackColor = Color.Transparent;
            lnklblForgotPass.ForeColor = Color.Transparent;
            lnklblForgotPass.LinkColor = SystemColors.ActiveCaption;
            lnklblForgotPass.Location = new Point(66, 227);
            lnklblForgotPass.Name = "lnklblForgotPass";
            lnklblForgotPass.Size = new Size(125, 20);
            lnklblForgotPass.TabIndex = 9;
            lnklblForgotPass.TabStop = true;
            lnklblForgotPass.Text = "Forgot Password?";
            lnklblForgotPass.LinkClicked += lnklblForgotPass_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(66, 162);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtbxPass
            // 
            txtbxPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPass.Location = new Point(66, 190);
            txtbxPass.Multiline = true;
            txtbxPass.Name = "txtbxPass";
            txtbxPass.Size = new Size(206, 34);
            txtbxPass.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(66, 84);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 31);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lnklblCreateAcc
            // 
            lnklblCreateAcc.AutoSize = true;
            lnklblCreateAcc.BackColor = Color.Transparent;
            lnklblCreateAcc.ForeColor = Color.Transparent;
            lnklblCreateAcc.LinkColor = SystemColors.ActiveCaption;
            lnklblCreateAcc.Location = new Point(98, 370);
            lnklblCreateAcc.Name = "lnklblCreateAcc";
            lnklblCreateAcc.Size = new Size(130, 20);
            lnklblCreateAcc.TabIndex = 3;
            lnklblCreateAcc.TabStop = true;
            lnklblCreateAcc.Text = "Create an Account";
            lnklblCreateAcc.LinkClicked += lnklblCreateAcc_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(156, 188, 95);
            label1.Location = new Point(82, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 46);
            label1.TabIndex = 2;
            label1.Text = "Welcome!";
            // 
            // txtbxUser
            // 
            txtbxUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUser.Location = new Point(66, 112);
            txtbxUser.Multiline = true;
            txtbxUser.Name = "txtbxUser";
            txtbxUser.Size = new Size(206, 34);
            txtbxUser.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(85, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 37);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(782, 504);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(782, 551);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgriFlow";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Exit;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private LinkLabel lnklblCreateAcc;
        private Label label1;
        private TextBox txtbxUser;
        private Button btnLogin;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox txtbxPass;
        private LinkLabel lnklblForgotPass;
        private Label label4;
        private PictureBox pictureBox3;
    }
}
