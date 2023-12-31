﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.SubjectRepo
{
    public interface IRepoSubject
    {
        public Subject CreateSubject(string title, string lectureType, string code, string year, string ects);

        public void WriteSubjectsToFile(List<Subject> subjects);
        public List<Subject> LoadSubjectsFromFile();
    }
}
