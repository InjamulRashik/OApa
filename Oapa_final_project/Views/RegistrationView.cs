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
    public partial class RegistrationView : Form
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        private void jMaterialTextboxNumber_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextboxName_Load(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserLoginView login = new UserLoginView();
            login.Show();

        }

        private void jMaterialTextboxPin_Load(object sender, EventArgs e)
        {

        }

        private void jThinButtonRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}
