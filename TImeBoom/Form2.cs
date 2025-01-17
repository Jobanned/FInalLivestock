using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TImeBoom.UserControls;

namespace TImeBoom
{
    public partial class Form2 : Form
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public string TimerName { get; private set; }
        public bool IsDeleted { get; private set; } = false;

        public Form2(int hours = 0, int minutes = 1, int seconds = 0, string name = "New Timer")
        {
            InitializeComponent();
            numHr.Value = hours;
            numMin.Value = minutes;
            numSec.Value = seconds;
            txtName.Text = name;
        }

        private void numHr_ValueChanged(object sender, EventArgs e)
        {
            if (numHr.Value < 0)
                numHr.Value = 0;
        }

        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            if (numMin.Value < 0)
                numMin.Value = 0;
            else if (numMin.Value > 59)
                numMin.Value = 59;
        }

        private void numSec_ValueChanged(object sender, EventArgs e)
        {
            if (numSec.Value < 0)
                numSec.Value = 0;
            else if (numSec.Value > 59)
                numSec.Value = 59;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Hours = (int)numHr.Value;
            Minutes = (int)numMin.Value;
            Seconds = (int)numSec.Value;
            TimerName = txtName.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsDeleted = true;
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
