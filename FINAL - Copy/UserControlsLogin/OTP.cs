using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class OTP : ForgotPassword
    {
        string UserEmail;
        string generateOTP;
        int count = 30;
        public OTP()
        {
            InitializeComponent();
        }

        public ForgotPassword ForgotPassword
        {
            get => default;
            set
            {
            }
        }

        private string enteredOTP()
        {
            return otp1.Text + otp2.Text + otp3.Text + otp4.Text + otp5.Text + otp6.Text;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string enterOTP = enteredOTP();
            if (enteredOTP() == generateOTP)
            {
                MessageBox.Show("OTP Verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewPass np = new NewPass(UserEmail);
                Control parentPanel = this.Parent;

                if (parentPanel != null)
                {
                    parentPanel.Controls.Remove(this);
                    np.Dock = DockStyle.Fill;
                    parentPanel.Controls.Add(np);
                    np.BringToFront();
                }
                else
                {
                    MessageBox.Show("Error: Parent panel not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void generateAndSendOTP()
        {
            Random random = new Random();
            generateOTP = random.Next(100000, 999999).ToString();

            try
            {
                sendOTPEmail(UserEmail, generateOTP);
                MessageBox.Show("OTP has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sendOTPEmail(string user, string generateOTP)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("playingkaachan@gmail.com", "avce vxxn zvqk dbcb");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("playingkaachan@gmail.com");
                mail.To.Add(user);
                mail.Subject = "OTP Verification";
                mail.Body = "Your OTP is: " + generateOTP;

                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void countDown()
        {
            lnklblResend.Enabled = false;
            count = 30;
            timerOTP.Interval = 1000;
            timerOTP.Tick += timerOTP_Tick;
            timerOTP.Start();
        }

        private void timerOTP_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                lnklblResend.Text = "Resend OTP (" + count + ")";
            }
            else
            {
                timerOTP.Stop();
                lnklblResend.Enabled = true;
                lnklblResend.Text = "Resend OTP";
            }
        }

        private void lnklblResend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generateAndSendOTP();
            countDown();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string enteredEmail = tbxEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredEmail))
            {
                MessageBox.Show("Please enter your email!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RetrieveEmailFromDatabase(enteredEmail);

            if (!string.IsNullOrEmpty(UserEmail))
            {
                generateAndSendOTP();
                countDown();
            }
            else
            {
                MessageBox.Show("Email not found in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RetrieveEmailFromDatabase(string enteredEmail)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ckarl\\OneDrive\\Documents\\Livestock.accdb";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                try
                {
                    myConn.Open();
                    string query = "SELECT Email FROM Account WHERE Email = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@Email", enteredEmail);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            UserEmail = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            return;
        }
    }
}
