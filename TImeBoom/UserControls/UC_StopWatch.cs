using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TImeBoom.UserControls
{
    public partial class UC_StopWatch : UserControl
    {
        public UC_StopWatch()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            timer1.Interval = 100;
        }
        private Stopwatch stopwatch;
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            stopwatch.Start();
            timer1.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            stopwatch.Reset();
            label1.Text = "00:00:00.000";
            timer1.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            stopwatch.Stop();
            timer1.Stop();
        }
        private void panelStopwatch_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.fff");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
