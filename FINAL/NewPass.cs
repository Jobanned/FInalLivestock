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
    public partial class NewPass : UserControl
    {
        public NewPass()
        {
            InitializeComponent();
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            return;
        }

        private void chxbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chxbxShowPass.Checked == true)
            {
                txtbxPass.UseSystemPasswordChar = false;
                txtbxNewPass.UseSystemPasswordChar = false;
                txtbxPass.PasswordChar = '\0';
                txtbxNewPass.PasswordChar = '\0';
            }
            else
            {
                txtbxPass.UseSystemPasswordChar = true;
                txtbxNewPass.UseSystemPasswordChar = true;
                txtbxPass.PasswordChar = '•';
                txtbxNewPass.PasswordChar = '•';
            }
        }
    }
}
