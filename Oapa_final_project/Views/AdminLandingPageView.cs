﻿using Oapa_final_project.Controllers;
using System;
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
        public AdminLandingPageView()
        {
            InitializeComponent();

        }
 

        private void jThinButtonShowUsers_Click(object sender, EventArgs e)
        {
            var users = UserController.GetAllUsers();
            dataGridViewShowInfo.DataSource = users;
        }
    }
}
