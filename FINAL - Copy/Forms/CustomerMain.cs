﻿using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class CustomerMain : MaterialForm
    {
        public CustomerMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.DeepOrange400, TextShade.WHITE);
        }

        public Login Login
        {
            get => default;
            set
            {
            }
        }

        private void CustomerMain_Load(object sender, EventArgs e)
        {

        }

        private void aboutAdmin1_Load(object sender, EventArgs e)
        {

        }
    }
}
