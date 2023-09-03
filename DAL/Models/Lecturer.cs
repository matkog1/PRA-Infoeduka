using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Lecturer
    {
        public Lecturer(string firstName, string lastName, string email, string address, string gSM, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            GSM = gSM;
            UserName = userName;
            Password = password;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string GSM { get; set; }

        public  string UserName { get; set; }

        public string Password { get; set; }

        public override string ToString() => $"{FirstName}, {LastName}, {Email}, {Address}, {GSM}, {UserName}, {Password}";
    }
}
