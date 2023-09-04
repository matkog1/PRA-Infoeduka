using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Post
    {
  
        public Post(Guid id,string title, string year, DateTime valid, string message)
        {
            Id = id;
            Title = title;
            Year = year;
            Valid = valid;
            Message = message;
        }

        public Post(string title, string year, DateTime valid, string message)
        {
            Id = Guid.NewGuid(); // Automatically generate a new GUID
            Title = title;
            Year = year;
            Valid = valid;
            Message = message;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Year { get; set; }

        public DateTime Valid { get; set; }

        public string Message { get; set; }

        public override string ToString() => $"{Id},{Title},{Year},{Valid},{Message}";

        public static Post Parse(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length < 4) return null;

            DateTime validDateTime;
            if (!DateTime.TryParse(parts[2].Trim(), out validDateTime))
            {
                return null;
            }

            return new Post(
            Guid.Parse(parts[0].Trim()), 
            parts[1].Trim(),
            parts[2].Trim(),
            validDateTime,
            parts[4].Trim()
            );
        }

    }
}
