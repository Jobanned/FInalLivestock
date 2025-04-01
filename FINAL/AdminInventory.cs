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
    public partial class AdminInventory : UserControl
    {
        public AdminInventory()
        {
            InitializeComponent();
        }

        private bool emptyFields()
        {
            if (tbxItemName.Text == "" || tbxPrice.Text == "" || tbxStock.Text == "" || cbxStatus.SelectedIndex == -1 || cbxType.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill out all fields.", "Errpr Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void btnImportPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                string imageLocation = "";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imgView.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearFields()
        {
            tbxItemName.Text = "";
            tbxPrice.Text = "";
            tbxStock.Text = "";
            cbxStatus.SelectedIndex = -1;
            cbxType.SelectedIndex = -1;
            imgView.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill out all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    MessageBox.Show("Item updated successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
            }
        }
    }
}
