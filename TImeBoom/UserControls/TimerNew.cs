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
    public partial class TimerNew : UserControl
    {
        private System.Windows.Forms.Timer timer;
        private int timeRemaining;
        private int hours, minutes, seconds;
        public event EventHandler<TimerNew> DeleteRequested;

        public TimerNew(int hours = 0, int minutes = 1, int seconds = 0, string name = "New Timer")
        {
            InitializeComponent();
            InitializeTimerControl();

            this.hours = Math.Max(0, Math.Min(23, hours));
            this.minutes = Math.Max(0, Math.Min(59, minutes));
            this.seconds = Math.Max(0, Math.Min(59, seconds));
            lblTime.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            lblTimerName.Text = name; 
        }
        private void InitializeTimerControl()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                lblTime.Text = TimeSpan.FromSeconds(timeRemaining).ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time is up!", "Timer");
                btnStart.Text = "Start";
            }
        }
        public void SetTimerData(string timerName, int hours, int minutes, int seconds)
        {
            lblTime.Text = $"{timerName}: {hours:D2}:{minutes:D2}:{seconds:D2}";
        }
        private void TimerNew_Load(object sender, EventArgs e)
        {

        }

        private void ptxEditBtn_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2(hours, minutes, seconds, lblTimerName.Text);

            if (editor.ShowDialog() == DialogResult.OK)
            {
                hours = editor.Hours;
                minutes = editor.Minutes;
                seconds = editor.Seconds;
                lblTimerName.Text = editor.TimerName;
                lblTime.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }
            else if (editor.DialogResult == DialogResult.Abort)
            {
                DeleteRequested?.Invoke(this, this);
            }
        }
        private void lblTime_Click(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timeRemaining = (hours * 3600) + (minutes * 60) + seconds;
                timer.Start();
                btnStart.Text = "Pause";
            }
            else
            {
                timer.Stop();
                btnStart.Text = "Start";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            timer.Stop();
            lblTime.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            btnStart.Text = "Start";
        }

    }
}
