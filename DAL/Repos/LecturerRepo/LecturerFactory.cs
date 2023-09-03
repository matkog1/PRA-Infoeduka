using DAL.Repos.PostRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.LecturerRepo
{
    public static class LecturerFactory
    {
        public static IRepoLecturer GetRepo() => new RepoLecturer();
    }
}
