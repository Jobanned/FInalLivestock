namespace TImeBoom
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelContainer = new Panel();
            menuStrip1 = new MenuStrip();
            timeToolStripMenuItem = new ToolStripMenuItem();
            alarmToolStripMenuItem = new ToolStripMenuItem();
            stopwatchToolStripMenuItem = new ToolStripMenuItem();
            timerToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            panelContainer.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(35, 35, 35);
            panelContainer.Controls.Add(menuStrip1);
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(258, 560);
            panelContainer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(32, 32, 32);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { timeToolStripMenuItem, alarmToolStripMenuItem, stopwatchToolStripMenuItem, timerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(225, 560);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // timeToolStripMenuItem
            // 
            timeToolStripMenuItem.BackColor = Color.FromArgb(35, 35, 35);
            timeToolStripMenuItem.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeToolStripMenuItem.ForeColor = Color.DimGray;
            timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            timeToolStripMenuItem.Size = new Size(212, 49);
            timeToolStripMenuItem.Text = "Time";
            timeToolStripMenuItem.Click += timeToolStripMenuItem_Click;
            // 
            // alarmToolStripMenuItem
            // 
            alarmToolStripMenuItem.Font = new Font("Arial", 24F);
            alarmToolStripMenuItem.ForeColor = Color.DimGray;
            alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            alarmToolStripMenuItem.Size = new Size(212, 49);
            alarmToolStripMenuItem.Text = "Alarm";
            alarmToolStripMenuItem.Click += alarmToolStripMenuItem_Click;
            // 
            // stopwatchToolStripMenuItem
            // 
            stopwatchToolStripMenuItem.Font = new Font("Arial", 24F);
            stopwatchToolStripMenuItem.ForeColor = Color.DimGray;
            stopwatchToolStripMenuItem.Name = "stopwatchToolStripMenuItem";
            stopwatchToolStripMenuItem.Size = new Size(212, 49);
            stopwatchToolStripMenuItem.Text = "Stopwatch";
            stopwatchToolStripMenuItem.Click += stopwatchToolStripMenuItem_Click;
            // 
            // timerToolStripMenuItem
            // 
            timerToolStripMenuItem.Font = new Font("Arial", 24F);
            timerToolStripMenuItem.ForeColor = Color.DimGray;
            timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            timerToolStripMenuItem.Size = new Size(212, 49);
            timerToolStripMenuItem.Text = "Timer";
            timerToolStripMenuItem.Click += timerToolStripMenuItem_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(32, 32, 32);
            panelMain.Location = new Point(228, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(902, 560);
            panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 560);
            Controls.Add(panelMain);
            Controls.Add(panelContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clock";
            Load += Form1_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem timeToolStripMenuItem;
        private ToolStripMenuItem alarmToolStripMenuItem;
        private ToolStripMenuItem stopwatchToolStripMenuItem;
        private ToolStripMenuItem timerToolStripMenuItem;
        private Panel panelMain;
    }
}
