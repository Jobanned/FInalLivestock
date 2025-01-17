using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class EmailRecovery : UserControl
    {
        public EmailRecovery()
        {
            InitializeComponent();
        }

        private void lnklblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();

            int x = (this.ClientSize.Width - fp.Width) / 2;
            int y = (this.ClientSize.Height - fp.Height) / 2;

            fp.Location = new Point(x, y);
            fp.Size = new Size(384, 499);

            this.Controls.Add(fp);
            fp.BringToFront();
        }

        private void lnklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm != null)  // Check if the UserControl is inside a form
            {
                this.ParentForm.Show();  // Show the original form
                this.ParentForm.BringToFront();  // Bring it to the front
            }

            this.Hide();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            NewPass np = new NewPass();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void lnklblUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();

            int x = (this.ClientSize.Width - fp.Width) / 2;
            int y = (this.ClientSize.Height - fp.Height) / 2;

            fp.Location = new Point(x, y);
            fp.Size = new Size(384, 499);

            this.Controls.Add(fp);
            fp.BringToFront();
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            NewPass np = new NewPass();

            int x = (this.ClientSize.Width - np.Width) / 2;
            int y = (this.ClientSize.Height - np.Height) / 2;

            np.Location = new Point(x, y);
            np.Size = new Size(384, 499);

            this.Controls.Add(np);
            np.BringToFront();
        }
    }
}
