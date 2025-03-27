using FINAL;

namespace Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lnklblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }

        private void lnklblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
