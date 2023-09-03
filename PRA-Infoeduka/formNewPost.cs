using DAL.Repos.PostRepo;
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

namespace PRA_Infoeduka
{
    public partial class formNewPost : Form
    {
        IRepoPost repoPost;
        List<Post> posts = new List<Post>();
        public formNewPost()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Post post = repoPost.CreatePost(tbTitle.Text, cbYear.Text, datePicker.Value, rtbText.Text);
            posts.Add(post);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
