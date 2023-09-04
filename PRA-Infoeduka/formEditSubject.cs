using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;
using DAL.Repos.SubjectRepo;

namespace PRA_Infoeduka
{
    public partial class formEditSubject : Form
    {
        List<Subject> subjects;
        IRepoSubject repoSubject = SubjectFactory.GetRepo();
        public formEditSubject()
        {
            InitializeComponent();
            subjects = repoSubject.LoadSubjectsFromFile();
            this.cbSubjects.SelectedIndexChanged += new System.EventHandler(this.cbSubjects_SelectedIndexChanged);

            // Populate ComboBox
            cbSubjects.DataSource = subjects;
            cbSubjects.DisplayMember = "Title";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            subjects = ReadSubjectsFromFile();
        }

        public List<Subject> ReadSubjectsFromFile()
        {
            List<Subject> subjects = new List<Subject>();
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfSubjects.txt");
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    // Assuming each subject is a line and you can parse it into a Subject object
                    Subject subject = Subject.Parse(line);
                    subjects.Add(subject);
                }
            }
            return subjects;
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make sure something is selected
            if (cbSubjects.SelectedIndex != -1)
            {
                // Retrieve the selected Subject
                Subject selectedSubject = (Subject)cbSubjects.SelectedItem;

                // Populate the textboxes
                tbTitle.Text = selectedSubject.Title;
                tbLectureType.Text = selectedSubject.LectureType;
                tbCode.Text = selectedSubject.Code;
                tbYear.Text = selectedSubject.Year;
                tbEcts.Text = selectedSubject.ECTS;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbSubjects.SelectedIndex == -1)
            {
                // Nothing selected
                MessageBox.Show("Please select a subject to edit.", "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the selected Subject from the ComboBox
            Subject selectedSubject = (Subject)cbSubjects.SelectedItem;

            // Update its properties from the textboxes
            selectedSubject.Title = tbTitle.Text.Trim();
            selectedSubject.LectureType = tbLectureType.Text.Trim();
            selectedSubject.Code = tbCode.Text.Trim();
            selectedSubject.Year = tbYear.Text.Trim();
            selectedSubject.ECTS = tbEcts.Text.Trim();

            // Find the index of the selected subject in the list
            int index = subjects.FindIndex(x => x.Code == selectedSubject.Code); // Assuming Code is unique
            if (index != -1)
            {
                // Replace the item in the list
                subjects[index] = selectedSubject;
            }

            // Now, re-write the updated subjectsList back to the file.
            repoSubject.WriteSubjectsToFile(subjects);

            // Optionally, inform the user that the operation was successful
            MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
