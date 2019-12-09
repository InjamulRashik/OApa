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
using Oapa_final_project.Models;

namespace Oapa_final_project.Views
{
    public partial class BabyView : Form
    {
        public static string passRate = null;
        User user;
        public BabyView(dynamic user)
        {
            InitializeComponent();
            this.user = user;

            var babyList = BabyController.GetAllBabys();

            foreach (Baby baby in babyList)
            {
                ComboBoxBaby.Items.Add(baby.BabyId + ". " + baby.BabyName);

            }
        }

        

       

        

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (passRate != null)
            {
                new PayCalView(passRate).Show();
                this.Hide();
            }
        }

        

        

        private void jThinButtonShowSelect_Click(object sender, EventArgs e)
        {
            if (passRate != null)
            {
                new PayCalView(passRate).Show();
                this.Hide();
            }
        }

        private void ComboBoxBaby_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedString = ComboBoxBaby.Text;

            string ids = "";
            foreach (var i in selectedString)
            {
                if (i == '.')
                {
                    break;
                }
                ids = ids + i;
            }

            int id = Int32.Parse(ids);
            Baby bb = BabyController.GetBaby(id);

            labelBabyName.Text = bb.BabyName;
            labelBabyRate.Text = bb.BabyRate;
            passRate = bb.BabyRate;

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new LandingPageView(user).Show();
        }
    }
}
