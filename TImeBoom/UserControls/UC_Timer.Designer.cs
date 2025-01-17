namespace TImeBoom.UserControls
{
    partial class UC_Timer
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
            panelTimer = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addNewTimerToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTimer
            // 
            panelTimer.AutoScroll = true;
            panelTimer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTimer.Dock = DockStyle.Fill;
            panelTimer.Location = new Point(0, 0);
            panelTimer.Name = "panelTimer";
            panelTimer.Size = new Size(902, 560);
            panelTimer.TabIndex = 0;
            panelTimer.Paint += panelTimer_Paint;
            panelTimer.MouseDown += panelTimer_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addNewTimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(183, 28);
            // 
            // addNewTimerToolStripMenuItem
            // 
            addNewTimerToolStripMenuItem.Name = "addNewTimerToolStripMenuItem";
            addNewTimerToolStripMenuItem.Size = new Size(182, 24);
            addNewTimerToolStripMenuItem.Text = "Add New Timer";
            addNewTimerToolStripMenuItem.Click += addNewTimerToolStripMenuItem_Click;
            // 
            // UC_Timer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTimer);
            Name = "UC_Timer";
            Size = new Size(902, 560);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTimer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addNewTimerToolStripMenuItem;
    }
}
