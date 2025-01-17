using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TImeBoom.UserControls
{
    public partial class UC_Timer : UserControl
    {
        List<TimerNew> savedTimers = new List<TimerNew>();
        public UC_Timer()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
            this.MouseDown += panelTimer_MouseDown;

        }
        private void RemoveTimer(object sender, TimerNew timerControl)
        {

            timerControl.DeleteRequested -= RemoveTimer;
            timerControl.Dispose();
        }

        private void addNewTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                TimerNew newTimer = new TimerNew(editor.Hours, editor.Minutes, editor.Seconds, editor.TimerName);
                newTimer.DeleteRequested += RemoveTimer;
                newTimer.Dock = DockStyle.Top; 
                newTimer.BringToFront();
                savedTimers.Add(newTimer);
                panelTimer.Controls.Add(newTimer);
                panelTimer.Refresh();
            }
        }
        private void panelTimer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }
        }
        private void panelTimer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
