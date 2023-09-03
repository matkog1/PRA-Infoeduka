using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL.Repos.SubjectRepo
{
    internal class RepoSubject : IRepoSubject
    {
        List<Subject> _subjects;

        public Subject CreateSubject(string title, string lectureType, string code, string year, string ects)
        {
            return new Subject(title, lectureType, code, year, ects);
        }

        public void WriteSubjectsToFile(List<Subject> subjects)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfSubjects.txt");


            if (File.Exists(filePath))
            {

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Subject subject in subjects)
                    {
                        writer.WriteLine(subject.ToString());
                    }
                }
            }
            else
            {

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Subject subject in subjects)
                    {
                        writer.WriteLine(subject.ToString());
                    }
                }
            }
        }

        public List<Subject> LoadSubjectsFromFile()
        {
            // Initialize your subjects list
            List<Subject>subjects = new List<Subject>();

            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(startupPath, "ListOfSubjects.txt");

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
                            Subject subject = new Subject(elements[0], elements[1], elements[2], elements[3], elements[4]);
                            subjects.Add(subject);
                        }
                    }
                }
            }

            return subjects;
        }

    }


}
