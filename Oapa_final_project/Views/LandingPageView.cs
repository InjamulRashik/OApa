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
            labelName1.Text = user.Name;
            this.user = user;

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

        private void LandingPageView_Load(object sender, EventArgs e)
        {

        }
    }
}
