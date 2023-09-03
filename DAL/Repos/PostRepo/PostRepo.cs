using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.PostRepo
{
    internal class PostRepo : IRepoPost
    {
        public Post CreatePost(string title, string year, DateTime date, string text)
        {
            Post post = new Post
            {
                Title = title,
                Year = year,
                Valid = date,
                Text = text
            };

            return post;
        }
    }
}
