using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TImeBoom.UserControls
{
    public partial class UC_Alarm : UserControl
    {
        List<AlarmNew> savedAlarm = new List<AlarmNew>();
        public UC_Alarm()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
            this.MouseDown += panelAlarm_MouseDown;
        }
        private void RemoveAlarm(object sender, AlarmNew alarmNew)
        {
            alarmNew.DeleteRequested -= RemoveAlarm;
            alarmNew.Dispose();
        }
        private void addNewAlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlarmEditor editor = new AlarmEditor();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                AlarmNew newAlarm = new AlarmNew();

                newAlarm.DeleteRequested += RemoveAlarm;
                newAlarm.Dock = DockStyle.Top;
                newAlarm.BringToFront();
                savedAlarm.Add(newAlarm);
                panelAlarm.Controls.Add(newAlarm);
                panelAlarm.Refresh();
            }
        }
        private void panelAlarm_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void panelAlarm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }
        }
        private void panelAlarm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
