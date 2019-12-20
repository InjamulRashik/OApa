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
    public partial class UserLoginView : Form
    {
        public UserLoginView()
        {
            InitializeComponent();
        }

        private void jMetroTextBoxNumber_Load(object sender, EventArgs e)
        {

        }

        private void labelPin_Click(object sender, EventArgs e)
        {

        }

        private void jMetroTextBoxPin_Load(object sender, EventArgs e)
        {

        }

        private void jThinButtonUserLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*LandingPageView landingPage = new LandingPageView();
            landingPage.Show();*/

            var result = LoginController.AuthenticateUser(jMetroTextBoxNumber.TextName, jMetroTextBoxPin.TextName);
            if (result != null)
            {
                //MessageBox.Show("Success", "Alert");
                new LandingPageView(result).Show();
            }
            else
            {

               DialogResult result1 =  MessageBox.Show("Number/Pin Does not Match", "Alert");
                if (result1 == DialogResult.OK)
                {

                    UserLoginView userLoginView = new UserLoginView();
                    userLoginView.Show();

                }
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationView registerForm = new RegistrationView();
            registerForm.Show();
            
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelNumberLog_Click(object sender, EventArgs e)
        {

        }
    }
}
