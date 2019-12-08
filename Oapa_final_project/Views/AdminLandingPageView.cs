using Oapa_final_project.Controllers;
using System;
using System.Collections;
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
    public partial class AdminLandingPageView : Form
    {
        public AdminLandingPageView(dynamic result)
        {
            InitializeComponent();

        }

        private void jThinButtonShowUsers_Click_1(object sender, EventArgs e)
        {
            ArrayList users = UserController.GetAllUsers();
            //dataGridViewShowInfo.DataSource = users;
            dataGridView1.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList users = UserController.GetAllUsers();
            //dataGridViewShowInfo.DataSource = users;
            dataGridView1.DataSource = users;
        }

        private void jThinButtonShowMaids_Click(object sender, EventArgs e)
        {
            ArrayList maids = MaidController.GetAllMaids();
            dataGridView1.DataSource = maids;
        }

        private void jThinButtonShowBabys_Click(object sender, EventArgs e)
        {
            ArrayList babys = BabyController.GetAllBabys();
            dataGridView1.DataSource = babys;
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePageView homePageView = new HomePageView();
            homePageView.Show();
        }
    }
 
}
