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
        public Post CreatePost(string title, string year, DateTime valid, string text);

        public void WritePostToFile(List<Post> posts);
        public List<Post> LoadPostsFromFile();

        public void RemovePostFromFile(Guid postId);

        public void AppendPostToFile(Post post);

    }
}
