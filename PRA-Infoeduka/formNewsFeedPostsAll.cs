using DAL.Models;
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

namespace PRA_Infoeduka
{
    public partial class formNewsFeedPostsAll : Form
    {
        IRepoPost repoPost = PostFactory.GetRepo();
        List<Post> posts = new List<Post>();


        public formNewsFeedPostsAll()
        {
            InitializeComponent();
            posts = repoPost.LoadPostsFromFile();
            PopulateFlowLayoutPanelWithPosts(posts, flpPosts);
        }

        public void PopulateFlowLayoutPanelWithPosts(List<Post> posts, FlowLayoutPanel flowLayoutPanel)
        {
            // First clear the existing controls, if you want
            flowLayoutPanel.Controls.Clear();

            foreach (Post post in posts)
            {
                NewsPost newsPost = new NewsPost();
                newsPost.PostTitle = post.Title;
                newsPost.PostYear = post.Year;
                newsPost.PostMessage = post.Message;

                // Add the UserControl to the FlowLayoutPanel
                flowLayoutPanel.Controls.Add(newsPost);
            }
        }
    }

}
