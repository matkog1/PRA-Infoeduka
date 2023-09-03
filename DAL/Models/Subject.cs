using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Subject
    {
        public Subject(string title, string lectureType, string code, string year, string eCTS)
        {
            Title = title;
            LectureType = lectureType;
            Code = code;
            Year = year;
            ECTS = eCTS;
        }

        public string Title { get; set; }
        public string LectureType { get; set; }
        public string Code { get; set; } 

        public string Year { get; set; } 

        public string ECTS { get; set; } 

        public override string ToString() => $"{Title},{LectureType}, {Code}, {Year}, {ECTS}";
        
    }
}
