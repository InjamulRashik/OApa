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
    public partial class PaySlipView : Form
    {
        //private dynamic user;
        //private dynamic result;

        public PaySlipView(dynamic min, dynamic sec, dynamic rate)
        {
            InitializeComponent();
            int totSec = min * 60 + sec;
            int rt = Int32.Parse(rate);

            double cost_without_scharge = (rt * totSec) / 3600;
            double cost_with_scharge = cost_without_scharge * 1.10;

            labelRate.Text = rate;
            labelTotCost.Text = cost_with_scharge.ToString();
            Console.WriteLine(min + "  " + sec + " " + rate + " " + cost_with_scharge);
            labelMin.Text = min.ToString();
            labelSec.Text = sec.ToString();
        }

        private void richTextBoxPaymentSlip_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void PaySlipView_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void jThinButtonDone_Click(object sender, EventArgs e)
        {
            //this.Close();
            //new LandingPageView(result).Show();
            Application.Exit();
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormClosingClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
