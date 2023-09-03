using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.LecturerRepo
{
    public interface IRepoLecturer
    {
        public Lecturer CreateLecturer(string firstName, string lastName, string email, string address, string gsm,string username, string password);

        public void WriteLecturerToFile(List<Lecturer> lecturers);
        public List<Lecturer> LoadLecturerFromFile();
    }
}
