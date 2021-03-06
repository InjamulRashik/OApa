﻿using Oapa_final_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oapa_final_project.Controllers;
using System.Collections;

namespace Oapa_final_project.Views
{
    public partial class UserHireHistoryView : Form
    {
        User user;

        public UserHireHistoryView(dynamic user)
        {
            InitializeComponent();
            this.user = user;
            labelUserName.Text = user.Name;
            
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new LandingPageView(user).Show();
        }

        private void jThinButtonShowMaids_Click(object sender, EventArgs e)
        {
            
            ArrayList maidHireinfos = MaidInfoController.GetAllMaidHistory(labelUserName.Text);
            //dataGridViewShowInfo.DataSource = users;
            dataGridViewHistory.DataSource = maidHireinfos;
        }

        private void jThinButtonShowBabys_Click(object sender, EventArgs e)
        {
            ArrayList babyHireinfos = BabyInfoController.GetAllBabyHistory(labelUserName.Text);
            //dataGridViewShowInfo.DataSource = users;
            dataGridViewHistory.DataSource = babyHireinfos;
        }
    }
}
