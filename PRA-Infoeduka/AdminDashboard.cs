using System.Net.Http.Headers;

namespace PRA_Infoeduka
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadSettings();

        }

        private void LoadSettings()
        {
            panelSubjects.Visible = false;
            panelUsers.Visible = false;
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            ShowSubjectsPanel();
        }

        private void ShowSubjectsPanel()
        {
            if (panelSubjects.Visible)
            {
                panelSubjects.Visible = false;
            }
            else
            {
                panelSubjects.Visible = true;
            }
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ShowUsersPanel();
        }

        private void ShowUsersPanel()
        {
            if (panelUsers.Visible)
            {
                panelUsers.Visible = false;
            }
            else
            {
                panelUsers.Visible = true;
            }
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

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            formNewUser formNewUser = new formNewUser();
            LoadForm(formNewUser);
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            formEditUser formEditUser = new formEditUser();
            LoadForm(formEditUser);
        }
    }
}