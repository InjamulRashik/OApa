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
    public partial class AdminLoginView : Form
    {
        public AdminLoginView()
        {
            InitializeComponent();
        }

        private void jThinButtonAdminLogin_Click(object sender, EventArgs e)
        {
            var result = AdminLoginController.AuthenticateAdmin(jMetroTextBoxAdminId.TextName,jMetroTextBoxAdminPassword.TextName);
            if (result != null)
            {
                MessageBox.Show("Success", "Alert");
                //new AdminLandingPageView(result).Show();

            }
            else
            {
                MessageBox.Show("Failure", "Alert");
            }
        }
    }
}
