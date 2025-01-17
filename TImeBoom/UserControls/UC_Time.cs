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
    public partial class UC_Time : UserControl
    {
        public UC_Time()
        {
            InitializeComponent();
        }

        private void panelTime_Paint(object sender, PaintEventArgs e)
        {
            textHour.Text = DateTime.Now.Hour.ToString("00");
            textMins.Text = DateTime.Now.Minute.ToString("00");
            textSecs.Text = DateTime.Now.Second.ToString("00");
            timerSeconds.Start();
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            textHour.Text = DateTime.Now.Hour.ToString("00");
            textMins.Text = DateTime.Now.Minute.ToString("00");
            textSecs.Text = DateTime.Now.Second.ToString("00");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
