using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClassroomProject
{
    class Classroom
    {
        List<Student> students;
        public Classroom(int capacity_)
        {
            Capacity = capacity_;
            students = new List<Student>();
        }        
        public int Capacity { get; set; }
        public int Count => students.Count;
        public int GetStudentsCount()
        {
            return students.Count;
        }

        
        public string RegisterStudent(Student student) 
        {
            if (students.Count() < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            if (students.Exists(n => n.FirstName == firstName && n.LastName == lastName))
            {
                students.Remove(students.FirstOrDefault(n => n.FirstName == firstName && n.LastName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }            
        }
        public string GetSubjectInfo(string subject)
        {
            if (students.Exists(n => n.Subject == subject))
            {
                List <Student> subjected = students.Where(n => n.Subject == subject).ToList();
                string returned = $"Subject: {subject}\nStudents:\n";
                foreach (var item in subjected)
                {
                    returned += $"{item.FirstName} {item.LastName}\n";
                }
                return returned.TrimEnd();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }
        public Student GetStudent(string firstName, string lastName)
        {
                Student the = students.FirstOrDefault(n => n.FirstName == firstName && n.LastName == lastName);
                return the;
        }
    }
}
