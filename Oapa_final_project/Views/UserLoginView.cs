﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oapa_final_project
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void jMetroTextBoxNumber_Load(object sender, EventArgs e)
        {

        }

        private void labelPin_Click(object sender, EventArgs e)
        {

        }

        private void jMetroTextBoxPin_Load(object sender, EventArgs e)
        {

        }

        private void jThinButtonUserLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registerForm = new Registration();
            registerForm.Show();
            
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelNumberLog_Click(object sender, EventArgs e)
        {

        }
    }
}