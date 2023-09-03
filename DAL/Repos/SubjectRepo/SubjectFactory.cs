using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.SubjectRepo
{
    public static class SubjectFactory
    {
        public static IRepoSubject GetRepo() => new RepoSubject();
    }
}
