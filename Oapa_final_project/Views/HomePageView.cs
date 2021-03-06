﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oapa_final_project.Views
{
    public partial class HomePageView : Form
    {
        public HomePageView()
        {
            InitializeComponent();
        }

        private void circularButtonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginView adminLoginView = new AdminLoginView();
            adminLoginView.Show();

        }

        private void circularButtonUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLoginView userLoginView = new UserLoginView();
            userLoginView.Show();
        }

        private void FormClosingClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
