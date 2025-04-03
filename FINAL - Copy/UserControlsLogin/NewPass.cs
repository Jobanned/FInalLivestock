using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Security.Cryptography;

namespace Final
{
    public partial class NewPass : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        string Email;
        public NewPass(string UserEmail)
        {
            InitializeComponent();
            Email = UserEmail;

        }

        public OTP OTP
        {
            get => default;
            set
            {
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb");
            string updatePass = "UPDATE Account SET [Password] = @password WHERE Email = @email";
            myConn.Open();
            if (tbxPass.Text == string.Empty || tbxNewPass.Text == string.Empty)
            {
                MessageBox.Show("Please fill up all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbxPass.Text != tbxNewPass.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = HashPassword(tbxPass.Text);
            cmd = new OleDbCommand(updatePass, myConn);
            cmd.Parameters.AddWithValue("@password", hashedPassword);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            myConn.Close();

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbxPass.UseSystemPasswordChar = false;
                tbxNewPass.UseSystemPasswordChar = false;
                tbxPass.PasswordChar = '\0';
                tbxNewPass.PasswordChar = '\0';
            }
            else
            {
                tbxPass.UseSystemPasswordChar = true;
                tbxNewPass.UseSystemPasswordChar = true;
                tbxPass.PasswordChar = '•';
                tbxNewPass.PasswordChar = '•';
            }

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

        private void tbxNewPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
