using TImeBoom.UserControls;

namespace TImeBoom
{
    public partial class Form1 : Form
    {
        UserControls.UC_Timer timer = new UserControls.UC_Timer();
        UserControls.UC_Time time = new UserControls.UC_Time();
        UserControls.UC_Alarm alarm = new UserControls.UC_Alarm();
        UserControls.UC_StopWatch stopwatch = new UserControls.UC_StopWatch();
        public Form1()
        {
            InitializeComponent();

        }
        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(time);
            time.Dock = DockStyle.Fill;
        }

        private void alarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(alarm);
            alarm.Dock = DockStyle.Fill;
        }

        private void stopwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(stopwatch);
            stopwatch.Dock = DockStyle.Fill;
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(timer);
            timer.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(time);
            time.Dock = DockStyle.Fill;
        }
    }
}
