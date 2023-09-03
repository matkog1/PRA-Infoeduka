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
    public partial class formEditUser : Form
    {
        List<Lecturer> lecturers;
        IRepoLecturer repoLecturer = LecturerFactory.GetRepo();
        public formEditUser()
        {
            InitializeComponent();
            lecturers = repoLecturer.LoadLecturerFromFile();
            this.cbLecturers.SelectedIndexChanged += new System.EventHandler(this.cbLecturers_SelectedIndexChanged);
            cbLecturers.Format += new ListControlConvertEventHandler(cbLecturers_Format);

            // Populate ComboBox
            cbLecturers.DataSource = lecturers;
            cbLecturers.DisplayMember = "FirstName";
        }

        public List<Lecturer> ReadLecturersFromFile()
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfLecturers.txt");
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    // Assuming each subject is a line and you can parse it into a Subject object
                    Lecturer lecturer = Lecturer.Parse(line);
                    lecturers.Add(lecturer);
                }
            }
            return lecturers;
        }

        private void cbLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make sure something is selected
            if (cbLecturers.SelectedIndex != -1)
            {
                // Retrieve the selected Subject
                Lecturer selectedLecturer = (Lecturer)cbLecturers.SelectedItem;

                // Populate the textboxes
                tbFirstName.Text = selectedLecturer.FirstName;
                tbLastName.Text = selectedLecturer.LastName;
                tbEmail.Text = selectedLecturer.Email;
                tbAddress.Text = selectedLecturer.Address;
                tbGsm.Text = selectedLecturer.GSM;
                tbUsername.Text = selectedLecturer.UserName;
                tbPassword.Text = selectedLecturer.Password;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbLecturers.SelectedIndex == -1)
            {
                // Nothing selected
                MessageBox.Show("Please select a subject to edit.", "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the selected Subject from the ComboBox
            Lecturer selectedLecturer = (Lecturer)cbLecturers.SelectedItem;

            // Update its properties from the textboxes
            selectedLecturer.FirstName = tbFirstName.Text.Trim();
            selectedLecturer.LastName = tbLastName.Text.Trim();
            selectedLecturer.Email = tbEmail.Text.Trim();
            selectedLecturer.Address = tbAddress.Text.Trim();
            selectedLecturer.GSM = tbGsm.Text.Trim();
            selectedLecturer.UserName = tbUsername.Text.Trim();
            selectedLecturer.Password = tbPassword.Text.Trim();

            // Find the index of the selected subject in the list
            int index = lecturers.FindIndex(x => x.Id == selectedLecturer.Id); // Assuming Code is unique
            if (index != -1)
            {
                // Replace the item in the list
                lecturers[index] = selectedLecturer;
            }

            // Now, re-write the updated subjectsList back to the file.
            repoLecturer.WriteLecturerToFile(lecturers);

            // Optionally, inform the user that the operation was successful
            MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbLecturers_Format(object sender, ListControlConvertEventArgs e)
        {
            Lecturer lecturer = e.ListItem as Lecturer;
            if (lecturer != null)
            {
                e.Value = $"{lecturer.FirstName} {lecturer.LastName}";
            }
        }
    }
}
