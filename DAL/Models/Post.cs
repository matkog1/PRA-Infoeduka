using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Year { get; set; }

        public DateTime Valid { get; set; }

        public string Text { get; set; }

        public override string ToString() => $"{Title}, {Year},{Valid}, {Text}";
    }
}
