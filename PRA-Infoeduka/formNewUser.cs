using DAL.Models;
using DAL.Repos.LecturerRepo;
using DAL.Repos.SubjectRepo;
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
    public partial class formNewUser : Form
    {
        List<Lecturer> lecturers = new List<Lecturer>();
        IRepoLecturer repoLecturer;
        public formNewUser()
        {
            InitializeComponent();
            repoLecturer = LecturerFactory.GetRepo();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(lecturers == null)
            {
                lecturers = new List<Lecturer>();
            }
            if (ValidateInputs())
            {

                Lecturer lecturer = repoLecturer.CreateLecturer(tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbAddress.Text, tbGsm.Text, tbUsername.Text, tbPassword.Text);
                lecturers.Add(lecturer);
                repoLecturer.WriteLecturerToFile(lecturers);
                ShowMessageConfirm();
                ClearTextBoxes();
            }
            else
            {
                ShowMessageFailed();
            }
        }

        private void ClearTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(tbFirstName.Text) &&
                   !string.IsNullOrWhiteSpace(tbLastName.Text) &&
                   !string.IsNullOrWhiteSpace(tbEmail.Text) &&
                   !string.IsNullOrWhiteSpace(tbAddress.Text) &&
                   !string.IsNullOrWhiteSpace(tbGsm.Text) &&
                   !string.IsNullOrWhiteSpace(tbUsername.Text) &&
                   !string.IsNullOrWhiteSpace(tbPassword.Text);
        }

        private static void ShowMessageFailed()
        {
            MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void ShowMessageConfirm()
        {
            MessageBox.Show("Lecturer has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
