using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.PostRepo
{
    public interface IRepoPost
    {
        public Post CreatePost(string title, string year, DateTime date, string text);
    }
}
