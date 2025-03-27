using FINAL;

namespace Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtbxUser.Text;
            string password = tbxPass.Text;

            if (IsAdmin(username, password))
            {
                AdminMain am = new AdminMain();
                am.Show();
                this.Hide();
            }
            else if (IsCustomer(username, password))
            {
                CustomerMain cm = new CustomerMain();
                cm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private bool IsAdmin(string username, string password)
        {
            // Implement your admin authentication logic here
            return username == "admin" && password == "123";
        }

        private bool IsCustomer(string username, string password)
        {
            // Implement your customer authentication logic here
            return username == "customer" && password == "customer123";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
           // this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
