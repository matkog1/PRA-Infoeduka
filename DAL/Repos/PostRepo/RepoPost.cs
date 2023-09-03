using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.PostRepo
{
    internal class RepoPost : IRepoPost
    {
        List<Post> posts;
        public Post CreatePost(string title, string year, DateTime valid, string text)
        {
            return new Post(title,year,valid,text);
        }

        public List<Post> LoadPostsFromFile()
        {
            List<Post> posts = new List<Post>();
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfPosts.txt");

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] elements = line.Split(','); // Replace with your actual delimiter
                        if (elements.Length >= 5)
                        {
                            Guid id = Guid.Parse(elements[0]);
                            string title = elements[1].Trim();
                            string year = elements[2].Trim();
                            DateTime expirationDate = DateTime.Parse(elements[3].Trim()); // Convert string to DateTime
                            string text = elements[4].Trim();

                            // Your Post constructor and object creation might be different.
                            // Adjust accordingly.
                            Post post = new Post(id, title, year, expirationDate, text);
                            posts.Add(post);
                        }
                    }
                }
            }

            return posts;
        }


        public void WritePostToFile(List<Post> posts)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfPosts.txt");


            if (File.Exists(filePath))
            {

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Post post in posts)
                    {
                        writer.WriteLine(post.ToString());
                    }
                }
            }
            else
            {

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Post post in posts)
                    {
                        writer.WriteLine(post.ToString());
                    }
                }
            }
        }
    }
}
