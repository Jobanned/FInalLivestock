using FINAL;
using ReaLTaiizor.Forms;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final
{
    public partial class Login : BaseForm
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        public Login()
        {
            InitializeComponent();

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbxUser.Text == "admin" && tbxPass.Text == "123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminMain admin = new AdminMain();
                this.Hide();
                admin.ShowDialog();
                this.Close();
                return;
            }

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb\"");
          //  da = new OleDbDataAdapter("SELECT *FROM Account", myConn);

            if (string.IsNullOrWhiteSpace(txtbxUser.Text) || string.IsNullOrWhiteSpace(tbxPass.Text))
            {
                MessageBox.Show("Please enter username & password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = HashPassword(tbxPass.Text);
            string query = "SELECT Username FROM Account WHERE [Username] = ? AND [Password] = ?";

            try
            {
                myConn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@Username", txtbxUser.Text);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string userType = result.ToString();
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustomerMain cm = new CustomerMain();
                        cm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();
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

        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
