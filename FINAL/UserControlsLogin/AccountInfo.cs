using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class AccountInfo : UserControl
    {
        public AccountInfo()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)  // Check if the UserControl is inside a form
            {
                this.ParentForm.Show();  // Show the original form
                this.ParentForm.BringToFront();  // Bring it to the front
            }

            this.Hide();
        }
    }
}
