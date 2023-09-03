using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.SubjectRepo
{
    public static class SubjectFactory
    {
        public static IRepoSubject GetRepo() => new SubjectRepo();
    }
}
