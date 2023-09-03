using DAL.Models;
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
    public partial class newSubjectForm : Form
    {
        List<Subject> subjects = new List<Subject>();
        IRepoSubject repoSubject;
        public newSubjectForm()
        {
            InitializeComponent();
            repoSubject = SubjectFactory.GetRepo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (subjects == null) 
            {
                subjects = new List<Subject>();
            }
            if (ValidateInputs())
            {

                Subject subject = repoSubject.CreateSubject(tbTitle.Text, tbLectureType.Text, tbEcts.Text, tbYear.Text, tbCode.Text);
                subjects.Add(subject);
                repoSubject.WriteSubjectsToFile(subjects);
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
            return !string.IsNullOrWhiteSpace(tbTitle.Text) &&
                   !string.IsNullOrWhiteSpace(tbLectureType.Text) &&
                   !string.IsNullOrWhiteSpace(tbYear.Text) &&
                   !string.IsNullOrWhiteSpace(tbCode.Text) &&
                   !string.IsNullOrWhiteSpace(tbEcts.Text);
        }

        private static void ShowMessageFailed()
        {
            MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void ShowMessageConfirm()
        {
            MessageBox.Show("Subject has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
