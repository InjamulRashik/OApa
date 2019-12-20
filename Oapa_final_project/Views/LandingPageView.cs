using Oapa_final_project.Controllers;
using Oapa_final_project.Models;
using Oapa_final_project.Views;
using System;
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
    public partial class LandingPageView : Form
    {

        User user;
        

        public LandingPageView(dynamic user)
        {
            InitializeComponent();

            this.user = user;
            labelName2.Text = user.Name;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void circularButtonBaby_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BabyView(user).Show();

        }

        private void circularButtonMaid_Click(object sender, EventArgs e)
        {
            new MaidView(user).Show();
            this.Hide();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new UserHireHistoryView(user).Show();
        }

       
    }
}