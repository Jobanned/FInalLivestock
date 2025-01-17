namespace TImeBoom.UserControls
{
    partial class UC_StopWatch
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
            panelStopwatch = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnStop = new Button();
            btnReset = new Button();
            btnStart = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelStopwatch.SuspendLayout();
            SuspendLayout();
            // 
            // panelStopwatch
            // 
            panelStopwatch.Controls.Add(label5);
            panelStopwatch.Controls.Add(label4);
            panelStopwatch.Controls.Add(label3);
            panelStopwatch.Controls.Add(label2);
            panelStopwatch.Controls.Add(btnStop);
            panelStopwatch.Controls.Add(btnReset);
            panelStopwatch.Controls.Add(btnStart);
            panelStopwatch.Controls.Add(label1);
            panelStopwatch.Dock = DockStyle.Fill;
            panelStopwatch.Location = new Point(0, 0);
            panelStopwatch.Name = "panelStopwatch";
            panelStopwatch.Size = new Size(902, 560);
            panelStopwatch.TabIndex = 0;
            panelStopwatch.Paint += panelStopwatch_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(32, 32, 32);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(583, 276);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 7;
            label5.Text = "Millisecond";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 32, 32);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(474, 276);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Second";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 32, 32);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(366, 276);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Minute";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 32, 32);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(258, 276);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Hour";
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(32, 32, 32);
            btnStop.FlatStyle = FlatStyle.Popup;
            btnStop.Font = new Font("Arial", 22.2F);
            btnStop.ForeColor = Color.DarkGray;
            btnStop.Location = new Point(522, 333);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(133, 55);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(32, 32, 32);
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Arial", 22.2F);
            btnReset.ForeColor = Color.DarkGray;
            btnReset.Location = new Point(383, 333);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(133, 55);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(32, 32, 32);
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Arial", 22.2F);
            btnStart.ForeColor = Color.DarkGray;
            btnStart.Location = new Point(244, 333);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(133, 55);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 32, 32);
            label1.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(223, 172);
            label1.Name = "label1";
            label1.Size = new Size(456, 89);
            label1.TabIndex = 0;
            label1.Text = "00:00:00:00";
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UC_StopWatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelStopwatch);
            Name = "UC_StopWatch";
            Size = new Size(902, 560);
            panelStopwatch.ResumeLayout(false);
            panelStopwatch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStopwatch;
        private Button btnStop;
        private Button btnReset;
        private Button btnStart;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
