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
    public partial class PayCalView : Form
    {
        User user;
        public static string passRate;
        public PayCalView(dynamic rate,dynamic user)
        {
            this.user = user;
            InitializeComponent();
            labelRate.Text = rate;
            passRate = rate;
            int rt = Int32.Parse(rate);
            double tot = rt * 1.10;

            labelTc.Text = tot.ToString();
        }

        private void richTextBoxPaymentSlip_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        

        private void jThinButtonConfirm_Click(object sender, EventArgs e)
        {
            new QRView(passRate,user).Show();
            this.Hide();
        }

        private void PayCalView_Load_1(object sender, EventArgs e)
        {
            labelDateShow.Text = DateTime.Now.ToShortDateString();
            labelTimeShow.Text = DateTime.Now.ToString("hh tt");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void jThinButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LandingPageView(user).Show();
        }

        private void PayCalView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
