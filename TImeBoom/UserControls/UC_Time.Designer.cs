namespace TImeBoom.UserControls
{
    partial class UC_Time
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
            panelTime = new Panel();
            textBox4 = new TextBox();
            textSecs = new TextBox();
            textMins = new TextBox();
            textHour = new TextBox();
            timerSeconds = new System.Windows.Forms.Timer(components);
            panelTime.SuspendLayout();
            SuspendLayout();
            // 
            // panelTime
            // 
            panelTime.Controls.Add(textBox4);
            panelTime.Controls.Add(textSecs);
            panelTime.Controls.Add(textMins);
            panelTime.Controls.Add(textHour);
            panelTime.Dock = DockStyle.Fill;
            panelTime.Location = new Point(0, 0);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(902, 560);
            panelTime.TabIndex = 0;
            panelTime.Paint += panelTime_Paint;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(32, 32, 32);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.DimGray;
            textBox4.Location = new Point(332, 184);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(71, 157);
            textBox4.TabIndex = 3;
            textBox4.Text = ":";
            // 
            // textSecs
            // 
            textSecs.BackColor = Color.FromArgb(32, 32, 32);
            textSecs.BorderStyle = BorderStyle.None;
            textSecs.Enabled = false;
            textSecs.Font = new Font("Verdana", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSecs.ForeColor = Color.DimGray;
            textSecs.Location = new Point(603, 223);
            textSecs.Multiline = true;
            textSecs.Name = "textSecs";
            textSecs.ReadOnly = true;
            textSecs.Size = new Size(144, 107);
            textSecs.TabIndex = 2;
            textSecs.Text = "00";
            // 
            // textMins
            // 
            textMins.BackColor = Color.FromArgb(32, 32, 32);
            textMins.BorderStyle = BorderStyle.None;
            textMins.Enabled = false;
            textMins.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textMins.ForeColor = Color.DimGray;
            textMins.Location = new Point(409, 184);
            textMins.Multiline = true;
            textMins.Name = "textMins";
            textMins.ReadOnly = true;
            textMins.Size = new Size(188, 157);
            textMins.TabIndex = 1;
            textMins.Text = "00";
            // 
            // textHour
            // 
            textHour.BackColor = Color.FromArgb(32, 32, 32);
            textHour.BorderStyle = BorderStyle.None;
            textHour.Enabled = false;
            textHour.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textHour.ForeColor = Color.DimGray;
            textHour.Location = new Point(167, 184);
            textHour.Multiline = true;
            textHour.Name = "textHour";
            textHour.ReadOnly = true;
            textHour.Size = new Size(169, 157);
            textHour.TabIndex = 0;
            textHour.Text = "00";
            // 
            // timerSeconds
            // 
            timerSeconds.Tick += timerSeconds_Tick;
            // 
            // UC_Time
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTime);
            Name = "UC_Time";
            Size = new Size(902, 560);
            panelTime.ResumeLayout(false);
            panelTime.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTime;
        private TextBox textHour;
        private TextBox textSecs;
        private TextBox textMins;
        private TextBox textBox4;
        private System.Windows.Forms.Timer timerSeconds;
    }
}
