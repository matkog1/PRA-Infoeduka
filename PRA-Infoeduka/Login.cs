using DAL.Models;
using DAL.Repos.LecturerRepo;
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
        IRepoLecturer repoLecturer;

        public Login()
        {
            InitializeComponent();
            repoLecturer = LecturerFactory.GetRepo();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
            List<Lecturer> lecturers = repoLecturer.LoadLecturerFromFile();
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            // Hardkodiran admin za demo
            string adminUsername = "admin";
            string adminPassword = "admin";  

            if ((username == adminUsername && password == adminPassword) ||
                (lecturers != null && lecturers.Any(lecturer => lecturer.UserName == username && lecturer.Password == password)))
            {
                if (username == adminUsername)
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    UserDashboard userDashboard = new UserDashboard();
                    userDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Authentication Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
