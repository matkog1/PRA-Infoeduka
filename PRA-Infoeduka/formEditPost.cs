using DAL.Models;
using DAL.Repos.PostRepo;
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
    public partial class formEditPost : Form
    {
        List<Post> posts;
        IRepoPost repoPost = PostFactory.GetRepo();
        public formEditPost()
        {
            InitializeComponent();
            LoadSetting();
            posts = repoPost.LoadPostsFromFile();
            this.cbPost.SelectedIndexChanged += new System.EventHandler(this.cbPost_SelectedIndexChanged);

            // Populate ComboBox
            cbPost.DataSource = posts;
            cbPost.DisplayMember = "Title";
        }

        private void LoadSetting()
        {
            List<string> years = new List<string> { "Year 1", "Year 2", "Year 3", "Year 4", "Year 5", "All years" };
            cbYear.DataSource = years;
        }

        public List<Post> ReadSubjectsFromFile()
        {
            List<Post> posts = new List<Post>();
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfPosts.txt");
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    // Assuming each subject is a line and you can parse it into a Subject object
                    Post subject = Post.Parse(line);
                    posts.Add(subject);
                }
            }
            return posts;
        }

        private void cbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make sure something is selected
            if (cbPost.SelectedIndex != -1)
            {
                // Retrieve the selected Subject
                Post selectedPost = (Post)cbPost.SelectedItem;

                // Populate the textboxes
                cbPost.Text = selectedPost.Title;
                cbYear.Text = selectedPost.Year;
                rtbText.Text = selectedPost.Message;

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbPost.SelectedIndex == -1)
            {
                // Nothing selected
                MessageBox.Show("Please select a subject to edit.", "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the selected Subject from the ComboBox
            Post selectedPost = (Post)cbPost.SelectedItem;

            // Update its properties from the textboxes
            selectedPost.Title = cbPost.Text.Trim();
            selectedPost.Year = cbYear.Text.Trim();
            selectedPost.Message = rtbText.Text.Trim();

            // Find the index of the selected subject in the list
            int index = posts.FindIndex(x => x.Id == selectedPost.Id); // Assuming Code is unique
            if (index != -1)
            {
                // Replace the item in the list
                posts[index] = selectedPost;
            }

            // Now, re-write the updated subjectsList back to the file.
            repoPost.WritePostToFile(posts);

            // Optionally, inform the user that the operation was successful
            MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
