using Oapa_final_project.Controllers;
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
        public LandingPageView(dynamic user)
        {
            InitializeComponent();
            LabelNameShow.Text = user.Name;

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
            BabyView baby = new BabyView();
            baby.Show();

        }

        private void circularButtonMaid_Click(object sender, EventArgs e)
        {
            MaidView maid = new MaidView();
            maid.Show();
        }
    }
}
