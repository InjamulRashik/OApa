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
        public MaidBabyRegView()
        {
            InitializeComponent();
        }

        private void jThinButtonMaidRegister_Click(object sender, EventArgs e)
        {
            var result = MaidController.AddMaid(jMaterialTextboxMaidName.TextName, jMaterialTextboxMaidRate.TextName);
            if (!result) MessageBox.Show("Error", "Alert");
            else
            {
                DialogResult result1 = MessageBox.Show("Succesfully registered", "Alert");

                if (result1 == DialogResult.OK)
                {
                    this.Hide();
                    new UserLoginView().Show();
                }
            }
        }

        private void jThinButtonBabyRegister_Click(object sender, EventArgs e)
        {
            var result = BabyController.AddBaby(jMaterialTextboxBabyName.TextName, jMaterialTextBabyRate.TextName);
            if (!result) MessageBox.Show("Error", "Alert");
            else
            {
                DialogResult result1 = MessageBox.Show("Succesfully registered", "Alert");

                if (result1 == DialogResult.OK)
                {
                    this.Hide();
                    new UserLoginView().Show();
                }
            }
        }
    }
}
