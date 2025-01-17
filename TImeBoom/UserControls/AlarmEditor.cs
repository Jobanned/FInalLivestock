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
    public partial class AlarmEditor : Form
    {
        public bool IsDeleted { get; private set; } = false;
        public AlarmEditor()
        {
            InitializeComponent();
        }

        private void AlarmEditor_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }
        private void InitializeControls()
        {
            listAMPM.Items.Add("AM");
            listAMPM.Items.Add("PM");
            listAMPM.SelectedIndex = 0;
            cbxRepeat.CheckedChanged += (s, e) =>
            {
                bool isRepeatEnabled = cbxRepeat.Checked;
                chxMon.Enabled = isRepeatEnabled;
                chxTue.Enabled = isRepeatEnabled;
                chxWed.Enabled = isRepeatEnabled;
                chxThur.Enabled = isRepeatEnabled;
                chxFri.Enabled = isRepeatEnabled;
                chxSat.Enabled = isRepeatEnabled;
                chxSu.Enabled = isRepeatEnabled;
            };
            btnSave.Click += (s, e) => SaveAlarm();
            btnCancel.Click += (s, e) => this.Close();
        }
        private void SaveAlarm()
        {
            int hour = (int)numHr.Value;
            int minute = (int)numMin.Value;
            string ampm = listAMPM.SelectedItem.ToString();
            bool isRepeat = cbxRepeat.Checked;
            List<DayOfWeek> repeatDays = new List<DayOfWeek>();

            if (isRepeat)
            {
                if (chxMon.Checked) repeatDays.Add(DayOfWeek.Monday);
                if (chxTue.Checked) repeatDays.Add(DayOfWeek.Tuesday);
                if (chxWed.Checked) repeatDays.Add(DayOfWeek.Wednesday);
                if (chxThur.Checked) repeatDays.Add(DayOfWeek.Thursday);
                if (chxFri.Checked) repeatDays.Add(DayOfWeek.Friday);
                if (chxSat.Checked) repeatDays.Add(DayOfWeek.Saturday);
                if (chxSu.Checked) repeatDays.Add(DayOfWeek.Sunday);
            }
            if (ampm == "PM" && hour < 12) hour += 12;
            if (ampm == "AM" && hour == 12) hour = 0;

            DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);
            AlarmData = new AlarmData
            {
                AlarmTime = alarmTime,
                RepeatDays = repeatDays,
                IsRepeat = isRepeat
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            IsDeleted = true;
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        public AlarmData AlarmData { get; private set; }
    }
    public class AlarmData
    {
        public DateTime AlarmTime { get; set; }
        public List<DayOfWeek> RepeatDays { get; set; }
        public bool IsRepeat { get; set; }
    }
}
