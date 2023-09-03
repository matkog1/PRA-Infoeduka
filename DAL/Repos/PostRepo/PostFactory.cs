using DAL.Repos.SubjectRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.PostRepo
{
    public static class PostFactory
    {
        public static IRepoPost GetRepo() => new RepoPost();
    }
}
