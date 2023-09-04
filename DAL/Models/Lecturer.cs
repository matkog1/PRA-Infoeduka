using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Lecturer
    {
        public Lecturer(Guid id,string firstName, string lastName, string email, string address, string gsm, string userName, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            GSM = gsm;
            UserName = userName;
            Password = password;
            Subjects = new List<Subject>();
        }

        public Lecturer(string firstName, string lastName, string email, string address, string gSM, string userName, string password)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            GSM = gSM;
            UserName = userName;
            Password = password;
            Subjects = new List<Subject>();
        }
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string GSM { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public List<Subject> Subjects { get; set; }

        public override string ToString()
        {
            string subjectsString = string.Join(";", Subjects.Select(s => s.Title));
            return $"{FirstName}, {LastName}, {Email}, {Address}, {GSM}, {UserName}, {Password}, {subjectsString}";
        }


        public static Lecturer Parse(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length < 8) return null;  // Not a valid line

            string[] subjectTitles = parts[7].Split(';'); // subjects are separated by semicolon
            List<Subject> subjects = subjectTitles.Select(title => new Subject { Title = title.Trim() }).ToList();

            Lecturer lecturer = new Lecturer(
                parts[0].Trim(),
                parts[1].Trim(),
                parts[2].Trim(),
                parts[3].Trim(),
                parts[4].Trim(),
                parts[5].Trim(),
                parts[6].Trim()
            );

            lecturer.Subjects = subjects;

            return lecturer;
        }
    }
}
