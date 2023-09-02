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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            panelPosts.Visible = false;
        }

        private void ShowPostsPanel()
        {
            if (panelPosts.Visible)
            {
                panelPosts.Visible = false;
            }
            else
            {
                panelPosts.Visible = true;
            }
        }

        private void btnNewPost_Click(object sender, EventArgs e)
        {
            formNewPost formNewPost = new formNewPost();
            LoadForm(formNewPost);
        }

        private void LoadForm(Form form)
        {
            panelMainShow.Controls.Clear();
            if (form == null) return;
            EditFormSettings(form);
            panelMainShow.Controls.Add(form);
            form.Show();
        }
        private Form EditFormSettings(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            return form;
        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            formEditPost formEditPost = new formEditPost();
            LoadForm(formEditPost);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPostsPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formEditUser formEditUser = new formEditUser();
            LoadForm(formEditUser);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formUserSubjects formUserSubjects = new formUserSubjects();
            LoadForm(formUserSubjects);
        }
    }
}
