﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLineSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Membership m = new Membership();
            m.Show();
            this.Hide();
        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
