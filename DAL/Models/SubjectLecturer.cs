using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SubjectLecturer
    {
        public SubjectLecturer(int subjectId, Subject subject, int lecturerID, Lecturer lecturer)
        {
            SubjectId = subjectId;
            Subject = subject;
            LecturerID = lecturerID;
            Lecturer = lecturer;
        }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int LecturerID { get; set; }
        public Lecturer Lecturer { get; set; }

        public override string ToString()
        {
            return $"{SubjectId}, {Subject}, {LecturerID}, {Lecturer}";
        }
    }
}
