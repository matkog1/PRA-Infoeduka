using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SubjectRepo : IRepoSubject
    {
        
        public Subject CreateSubject(string title, string lectureType, string code, string year, string ects)
        {
            Subject subject = new Subject();
            subject.Title = title;
            subject.LectureType = lectureType;
            subject.Code = code;
            subject.Year = year;
            subject.ECTS = ects;
        
            return subject;
        }
    }
}
