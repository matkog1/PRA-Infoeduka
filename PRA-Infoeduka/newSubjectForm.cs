using DAL.Models;
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
        public newSubjectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Subject subject = CreateSubject();
                subjects.Add(subject);
                WriteSubjectsToFile(subjects);
                MessageBox.Show("Subject has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ClearTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();  // or ((TextBox)c).Text = "";
                }
            }
        }

        private Subject CreateSubject()
        {
            return new Subject(tbTitle.Text, tbLectureType.Text, tbCode.Text, tbYear.Text, tbEcts.Text);
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(tbTitle.Text) &&
                   !string.IsNullOrWhiteSpace(tbLectureType.Text) &&
                   !string.IsNullOrWhiteSpace(tbYear.Text) &&
                   !string.IsNullOrWhiteSpace(tbCode.Text) &&
                   !string.IsNullOrWhiteSpace(tbEcts.Text);
        }

        public static void WriteSubjectsToFile(List<Subject> subjects)
        {
            string startupPath = Application.StartupPath;
            string filePath = Path.Combine(startupPath, "SubjectList.txt");

            // Check if the file already exists
            if (File.Exists(filePath))
            {
                // If you want to append to the existing file rather than overwriting it, use FileMode.Append
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    foreach (Subject subject in subjects)
                    {
                        writer.WriteLine(subject.ToString());
                    }
                }
            }
            else
            {
                // Create the file and write the subjects to it
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Subject subject in subjects)
                    {
                        writer.WriteLine(subject.ToString());
                    }
                }
            }
        }
    }
}
