using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();

            int x = (this.ClientSize.Width - addItem.Width) / 2;
            int y = (this.ClientSize.Height - addItem.Height) / 2;

            addItem.Location = new Point(x, y);
            addItem.Size = new Size(384, 499);

            this.Controls.Add(addItem);
            addItem.BringToFront();
        }
    }
}
