using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.LecturerRepo
{
    internal class RepoLecturer : IRepoLecturer
    {
        public Lecturer CreateLecturer(string firstName, string lastName, string email, string address, string gsm,string username, string password)
        {
            return new Lecturer(firstName, lastName, email, address, gsm, username, password);
        }

        public List<Lecturer> LoadLecturerFromFile()
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfLecturers.txt");

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] elements = line.Split(',');
                        if (elements.Length >= 7) 
                        {
                            Lecturer lecturer = new Lecturer(elements[0].Trim(), elements[1].Trim(), elements[2].Trim(), elements[3].Trim(), elements[4].Trim(), elements[5].Trim(), elements[6].Trim());

                            if (elements.Length > 7)
                            {
                                string[] subjectTitles = elements[7].Split(';');
                                List<Subject> subjects = subjectTitles.Select(title => new Subject { Title = title.Trim() }).ToList();
                                lecturer.Subjects = subjects;
                            }

                            lecturers.Add(lecturer);
                        }
                    }
                }
            }

            return lecturers;
        }


        public void WriteLecturerToFile(List<Lecturer> lecturers)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfLecturers.txt");


            if (File.Exists(filePath))
            {

                using (StreamWriter writer = new StreamWriter(filePath))
                {

                    foreach (Lecturer lecturer in lecturers)
                    {
                        writer.WriteLine(lecturer.ToString());
                    }
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Lecturer lecturer in lecturers)
                    {
                        writer.WriteLine(lecturer.ToString());
                    }
                }
            }
        }
    }
}
