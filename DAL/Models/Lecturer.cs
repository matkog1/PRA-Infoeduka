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
        }
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string GSM { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public override string ToString() => $"{FirstName}, {LastName}, {Email}, {Address}, {GSM}, {UserName}, {Password}";

        public static Lecturer Parse(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length < 5) return null;  // Not a valid line

            return new Lecturer(
                parts[0].Trim(),
                parts[1].Trim(),
                parts[2].Trim(),
                parts[3].Trim(),
                parts[4].Trim(),
                parts[5].Trim(),
                parts[6].Trim()
            );
        }
    }
}
