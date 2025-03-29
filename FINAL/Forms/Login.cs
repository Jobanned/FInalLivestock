using FINAL;
using ReaLTaiizor.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;

namespace Final
{
    public partial class Login : Form
    {
        private const string Uname = "Admin";
        private const string Password = "123";
        string role = "User";
        public Login()
        {
            InitializeComponent();

        }
        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Convert byte to hex string
                }
                return builder.ToString() == storedHash; // Compare hashed values
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbxUser.Text == Uname && tbxPass.Text == Password)
            {
                AdminMain admin = new AdminMain();
                admin.Show();
                this.Hide();
                return;

            }
            using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb"))
            {
                myConn.Open();
                string query = "SELECT ID, Password FROM Account WHERE Username = @UserName";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@UserName", txtbxUser.Text);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // If username exists in database
                    {
                        int userID = Convert.ToInt32(reader["ID"]); // Fetch ID
                        string storedHash = reader["Password"].ToString(); // Fetch hashed password

                        if (VerifyPassword(tbxPass.Text, storedHash)) // Compare input password with stored hash
                        {
                            CustomerMain cm = new CustomerMain(userID, role);
                            cm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxShowPass.Checked == true)
            {
                tbxPass.UseSystemPasswordChar = false;
                tbxPass.PasswordChar = '\0';
                // tbxPass.PasswordChar = '*';
            }
            else
            {
                tbxPass.UseSystemPasswordChar = true;
                tbxPass.PasswordChar = '•';
            }
        }

        private void lnklblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }
    }
}
