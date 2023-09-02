using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Lecturer
    {
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
