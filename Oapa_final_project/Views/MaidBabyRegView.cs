using Oapa_final_project.Controllers;
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
    public partial class MaidBabyRegView : Form
    {
        //private dynamic result;

        public MaidBabyRegView()
        {
            InitializeComponent();
        }

        private void jThinButtonMaidRegister_Click(object sender, EventArgs e)
        {
            if(jMaterialTextboxMaidId == null | jMaterialTextboxMaidName.TextName == null | jMaterialTextboxMaidRate.TextName == null)
            {
                MessageBox.Show("Please Provide Informations", "Alert");
            }
            else { 
                var result = MaidController.AddMaid(jMaterialTextboxMaidId.TextName,jMaterialTextboxMaidName.TextName, jMaterialTextboxMaidRate.TextName);
                if (!result) MessageBox.Show("Error", "Alert");
                else
                {
                    DialogResult result1 = MessageBox.Show("Succesfully registered", "Alert");
                } 
            }
        }

        private void jThinButtonBabyRegister_Click(object sender, EventArgs e)
        {
            if (jMaterialTextboxBabyId.TextName == null | jMaterialTextboxBabyName.TextName == null | jMaterialTextBabyRate.TextName == null)
            {
                MessageBox.Show("Please Provide Informations", "Alert");
            }
            else
            {
                var result = BabyController.AddBaby(jMaterialTextboxBabyId.TextName,jMaterialTextboxBabyName.TextName, jMaterialTextBabyRate.TextName);
                if (!result) MessageBox.Show("Error", "Alert");
                else
                {
                    DialogResult result1 = MessageBox.Show("Succesfully registered", "Alert");
                }
            }
        }

        private void MaidBabyRegView_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void jMaterialTextboxMaidRate_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextboxMaidName_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox1_Load(object sender, EventArgs e)
        {

        }
    }
}
