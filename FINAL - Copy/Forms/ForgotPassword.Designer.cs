namespace Final
{
    partial class ForgotPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            panel1 = new Panel();
            label5 = new Label();
            Exit = new Button();
            pnlContainer = new Panel();
            otp1 = new OTP();
            panel1.SuspendLayout();
            pnlContainer.SuspendLayout();
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
            panel1.Size = new Size(764, 35);
            panel1.TabIndex = 55;
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
            Exit.Location = new Point(719, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(45, 35);
            Exit.TabIndex = 0;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(otp1);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 35);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(764, 469);
            pnlContainer.TabIndex = 56;
            pnlContainer.Paint += pnlContainer_Paint;
            // 
            // otp1
            // 
            otp1.Dock = DockStyle.Fill;
            otp1.Location = new Point(0, 0);
            otp1.Name = "otp1";
            otp1.Size = new Size(764, 469);
            otp1.TabIndex = 0;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 504);
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button Exit;
        private Panel pnlContainer;
        private Label label10;
        private OTP otp1;
    }
}