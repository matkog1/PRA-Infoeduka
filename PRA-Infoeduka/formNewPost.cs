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
using DAL.Repos.PostRepo;
using DAL.Repos.SubjectRepo;

namespace PRA_Infoeduka
{
    public partial class formNewPost : Form
    {

        List<Post> posts = new List<Post>();
        IRepoPost repoPosts;

        public formNewPost()
        {
            InitializeComponent();
            repoPosts = PostFactory.GetRepo();
            LoadSetting();
        }

        private void LoadSetting()
        {
            List<string> years = new List<string> { "Year 1", "Year 2", "Year 3", "Year 4", "Year 5", "All years" };
            cbYear.DataSource = years;
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (posts == null)
            {
                posts = new List<Post>();
            }
            if (ValidateInputs())
            {
                DateTime expirationDate = datePicker.Value;
                Post post = repoPosts.CreatePost(tbTitle.Text, cbYear.Text, expirationDate, rtbText.Text);
                posts.Add(post);
                repoPosts.WritePostToFile(posts);
                ShowMessageConfirm();
                ClearTextBoxes();
            }
            else
            {
                ShowMessageFailed();
            }
        }
        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(tbTitle.Text) &&
                   !string.IsNullOrWhiteSpace(cbYear.Text) &&
                   !string.IsNullOrWhiteSpace(datePicker.Text) &&
                   !string.IsNullOrWhiteSpace(rtbText.Text);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private static void ShowMessageConfirm()
        {
            MessageBox.Show("Post has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void ShowMessageFailed()
        {
            MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ClearTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1; // Clear selection
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
            }
        }
    }
}
