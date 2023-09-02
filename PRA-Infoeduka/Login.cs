using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRA_Infoeduka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
           string username = textBoxUserName.Text;
           string password = textBoxPassword.Text;

            if (username == "admin" && password == "admin")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();

            }
            else if (username == "user" && password == "user")
            {
                UserDashboard userDashboard = new UserDashboard();
                userDashboard.Show();
                this.Hide();
            }
        }
    }
}
