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
    public partial class MaidView : Form
    {
        public static string passRate = null;
        User user;
        
        public MaidView(dynamic user)
        {
            InitializeComponent();
            this.user = user;
            labelUserName.Text = user.Name;

            var maidList = MaidController.GetAllMaids();

            foreach(Maid maid in maidList)
            {
                ComboBoxBaby.Items.Add(maid.MaidId + ". " + maid.MaidName);
            }
        }

        private void ComboBoxMaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedString = ComboBoxBaby.Text;

            string ids = "";
            foreach(var i in selectedString)
            {
                if(i == '.')
                {
                    break;
                }
                ids = ids + i;
            }

            int id = Int32.Parse(ids);
            Maid md = MaidController.GetMaid(id);
            labelMaidName.Text = md.MaidName;
            labelMaidRate.Text = md.MaidRate;
            passRate = md.MaidRate;
            //workdone
        }

        private void MaidView_Load(object sender, EventArgs e)
        {

        }

        private void labelMaidName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(passRate != null)
            {
                new PayCalView(passRate).Show();
                this.Hide();
            }
        }

        private void jThinButtonShowSelect_Click(object sender, EventArgs e)
        {
            var result = MaidInfoController.AddInfo(labelUserName.Text,labelMaidName.Text);

            if (passRate != null)
            {
                
                new PayCalView(passRate).Show();
                this.Hide();
            }
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new LandingPageView(user).Show();

        }
    }
}
