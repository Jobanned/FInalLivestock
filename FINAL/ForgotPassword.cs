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
    public partial class ForgotPassword : UserControl
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void lnklblLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lnklblEmail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailRecovery er = new EmailRecovery();

            int x = (this.ClientSize.Width - er.Width) / 2;
            int y = (this.ClientSize.Height - er.Height) / 2;

            er.Location = new Point(x, y);
            er.Size = new Size(384, 499);

            this.Controls.Add(er);
            er.BringToFront();
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            NewPass np = new NewPass();
            this.Controls.Add(np);
            np.BringToFront();
        }
    }
}
