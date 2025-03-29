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
using System.Xml.Linq;
using System.Security.Cryptography;

namespace Final
{
    public partial class CreateAccount : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb"); 
            da = new OleDbDataAdapter("SELECT *FROM Account", myConn);
            string query = "Insert into Account ([Username], [Name], [Email], [PhoneNum], [Password]) values (@Username, @Name, @Email, @PhoneNum, @Password)";
            myConn.Open();
            if (tbxUser.Text == string.Empty || tbxName.Text == string.Empty || tbxPass.Text == string.Empty || tbxConPass.Text == string.Empty
                || tbxEmail.Text == string.Empty || tbxPhone.Text == string.Empty)
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbxPass.Text != tbxConPass.Text)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@username", tbxUser.Text);
            cmd.Parameters.AddWithValue("@fullname", tbxName.Text);
            cmd.Parameters.AddWithValue("@email", tbxEmail.Text);
            cmd.Parameters.AddWithValue("@phonenum", tbxPhone.Text);
            cmd.Parameters.AddWithValue("@password", HashPassword(tbxPass.Text));
            cmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            login.Show();
            this.Hide();
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
        

        private void chxbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chxbxShowPass.Checked == true)
            {
                tbxPass.UseSystemPasswordChar = false;
                tbxConPass.UseSystemPasswordChar = false;
                tbxConPass.PasswordChar = '\0';
                tbxPass.PasswordChar = '\0';
            }
            else
            {
                tbxPass.UseSystemPasswordChar = true;
                tbxConPass.UseSystemPasswordChar= true;
                tbxConPass.PasswordChar = '•';
                tbxPass.PasswordChar = '•';
            }
        }
    }
}
