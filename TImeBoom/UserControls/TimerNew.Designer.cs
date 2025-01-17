namespace TImeBoom.UserControls
{
    partial class TimerNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerNew));
            ptxEditBtn = new PictureBox();
            btnStop = new Button();
            btnStart = new Button();
            lblTime = new Label();
            lblTimerName = new Label();
            ((System.ComponentModel.ISupportInitialize)ptxEditBtn).BeginInit();
            SuspendLayout();
            // 
            // ptxEditBtn
            // 
            ptxEditBtn.Image = (Image)resources.GetObject("ptxEditBtn.Image");
            ptxEditBtn.Location = new Point(308, 10);
            ptxEditBtn.Name = "ptxEditBtn";
            ptxEditBtn.Size = new Size(39, 36);
            ptxEditBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ptxEditBtn.TabIndex = 7;
            ptxEditBtn.TabStop = false;
            ptxEditBtn.Click += ptxEditBtn_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(32, 32, 32);
            btnStop.Font = new Font("Arial", 13.8F);
            btnStop.ForeColor = Color.LightGray;
            btnStop.Location = new Point(169, 193);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(128, 47);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(32, 32, 32);
            btnStart.Font = new Font("Arial", 13.8F);
            btnStart.ForeColor = Color.LightGray;
            btnStart.Location = new Point(35, 193);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(128, 47);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.FromArgb(32, 32, 32);
            lblTime.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(89, 108);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(164, 42);
            lblTime.TabIndex = 4;
            lblTime.Text = "00:00:00";
            lblTime.Click += lblTime_Click;
            // 
            // lblTimerName
            // 
            lblTimerName.AutoSize = true;
            lblTimerName.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimerName.Location = new Point(22, 26);
            lblTimerName.Name = "lblTimerName";
            lblTimerName.Size = new Size(0, 35);
            lblTimerName.TabIndex = 8;
            // 
            // TimerNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTime);
            Controls.Add(lblTimerName);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(ptxEditBtn);
            Name = "TimerNew";
            Size = new Size(357, 254);
            Load += TimerNew_Load;
            ((System.ComponentModel.ISupportInitialize)ptxEditBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptxEditBtn;
        private Button btnStop;
        private Button btnStart;
        private Label lblTime;
        private Label lblTimerName;
    }
}
