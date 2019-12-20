using Oapa_final_project.Models;
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
    public partial class UserHireHistoryView : Form
    {
        User user;

        public UserHireHistoryView(dynamic user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new LandingPageView(user).Show();
        }
    }
}
