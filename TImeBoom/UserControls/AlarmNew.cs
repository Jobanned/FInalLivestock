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
    public partial class AlarmNew : UserControl
    {
        private System.Windows.Forms.Timer timer;
        private DateTime alarmTime;
        private bool isAlarmEnabled = false;
        private List<DayOfWeek> repeatDays = new List<DayOfWeek>();
        public event EventHandler<AlarmNew> DeleteRequested;
        public AlarmNew()
        {
            InitializeComponent();
        }
        protected virtual void OnDeleteRequested()
        {
            DeleteRequested?.Invoke(this, this); 
        }

        public void Delete()
        {
            OnDeleteRequested(); 
        }
        private void AlarmNew_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += AlarmTimer_Tick;
            timer.Start();
        }
        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            if (isAlarmEnabled && DateTime.Now >= alarmTime && repeatDays.Contains(DateTime.Now.DayOfWeek))
            {
                TriggerAlarm();
            }
        }
        private void TriggerAlarm()
        {
            isAlarmEnabled = false;
            checkBox1.Checked = false;
            MessageBox.Show("Alarm! Wake up!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isAlarmEnabled = checkBox1.Checked;
            lblNotif.Text = isAlarmEnabled ? "Alarm Enabled" : "Alarm Disabled";
        }
        private void UpdateRepeatDays()
        {
            repeatDays.Clear();
            if (chxSu.Checked) repeatDays.Add(DayOfWeek.Sunday);
            if (chxMon.Checked) repeatDays.Add(DayOfWeek.Monday);
            if (chxTue.Checked) repeatDays.Add(DayOfWeek.Tuesday);
            if (chxWed.Checked) repeatDays.Add(DayOfWeek.Wednesday);
            if (chxThur.Checked) repeatDays.Add(DayOfWeek.Thursday);
            if (chxFri.Checked) repeatDays.Add(DayOfWeek.Friday);
            if (chxSat.Checked) repeatDays.Add(DayOfWeek.Saturday);
        }
        private void cbxSun_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxMon_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxTue_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxWed_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxThu_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxFri_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void cbxSat_CheckedChanged(object sender, EventArgs e) => UpdateRepeatDays();
        private void lblNotif_Click(object sender, EventArgs e)
        {

        }
        private void ptxEditBtn_Click(object sender, EventArgs e)
        {
            OpenAlarmEditor();
        }
        private void OpenAlarmEditor()
        {
            using (AlarmEditor editor = new AlarmEditor())
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    AlarmData alarmData = editor.AlarmData;
                    SetAlarm(alarmData.AlarmTime, alarmData.RepeatDays, alarmData.IsRepeat);

                }
            }
        }
        private void SetAlarm(DateTime alarmTime, List<DayOfWeek> repeatDays, bool isReapet)
        {

        }

    }
}
