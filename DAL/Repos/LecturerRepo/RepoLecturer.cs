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
            // Initialize your subjects list
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
                        // Assuming each line in the file represents a Subject
                        // and is formatted appropriately
                        // Here, you parse each line to construct a Subject object
                        // Then add it to the subjects list
                        string[] elements = line.Split(','); // Replace with your actual delimiter
                        if (elements.Length >= 5)
                        {
                            Lecturer lecturer = new Lecturer(elements[0], elements[1], elements[2], elements[3], elements[4], elements[5], elements[6]);
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
