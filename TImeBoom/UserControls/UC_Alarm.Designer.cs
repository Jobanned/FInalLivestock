namespace TImeBoom.UserControls
{
    partial class UC_Alarm
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
            panelAlarm = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addNewAlarmToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelAlarm
            // 
            panelAlarm.Dock = DockStyle.Fill;
            panelAlarm.Location = new Point(0, 0);
            panelAlarm.Name = "panelAlarm";
            panelAlarm.Size = new Size(902, 560);
            panelAlarm.TabIndex = 2;
            panelAlarm.Paint += panelAlarm_Paint;
            panelAlarm.MouseClick += panelAlarm_MouseClick;
            panelAlarm.MouseDown += panelAlarm_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addNewAlarmToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 28);
            // 
            // addNewAlarmToolStripMenuItem
            // 
            addNewAlarmToolStripMenuItem.Name = "addNewAlarmToolStripMenuItem";
            addNewAlarmToolStripMenuItem.Size = new Size(184, 24);
            addNewAlarmToolStripMenuItem.Text = "Add New Alarm";
            addNewAlarmToolStripMenuItem.Click += addNewAlarmToolStripMenuItem_Click;
            // 
            // UC_Alarm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAlarm);
            Name = "UC_Alarm";
            Size = new Size(902, 560);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAlarm;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addNewAlarmToolStripMenuItem;
    }
}
