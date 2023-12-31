﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Subject
    {

        public Subject()
        {
        }
        public Subject(Guid id,string title, string lectureType, string code, string year, string eCTS)
        {
            Id = id;
            Title = title;
            LectureType = lectureType;
            Code = code;
            Year = year;
            ECTS = eCTS;
        }

        public Subject(string title, string lectureType, string code, string year, string eCTS)
        {
            Id = Guid.NewGuid();
            Title = title;
            LectureType = lectureType;
            Code = code;
            Year = year;
            ECTS = eCTS;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string LectureType { get; set; }
        public string Code { get; set; } 

        public string Year { get; set; } 

        public string ECTS { get; set; } 

        public override string ToString() => $"{Id},{Title},{LectureType},{Code},{Year},{ECTS}";

        public static Subject Parse(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length < 5) return null;

            return new Subject(
                parts[0].Trim(),
                parts[1].Trim(),
                parts[2].Trim(),
                parts[3].Trim(),
                parts[4].Trim()
            );
        }
    }
}
