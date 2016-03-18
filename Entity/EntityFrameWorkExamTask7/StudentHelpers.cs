using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamTask7
{
    public static class StudentHelpers
    {
        public static Student AddAStudent(string firstName, string lastName, int age)
        {
            using (var ctx = new Registry())
            {
                Student newStudent = new Student();
                newStudent.FirstName = firstName;
                newStudent.LastName = lastName;
                newStudent.Age = age;

                ctx.Students.Add(newStudent);
                ctx.SaveChanges();
                return newStudent;
            }
           
        }
        public static List<Student> SearchForAStudent(string searchText)
        {
            using (var ctx = new Registry())
            {
                List<Student> SearchingForStudent =
                    ctx.Students.Where(s => s.FirstName.Contains(searchText) || s.LastName.Contains(searchText))
                        .ToList();
                return SearchingForStudent;
            }
        }

        public static Student FindStudentWithId(int id)
        {
            using (var ctx = new Registry())
            {
                Student getStudentWithId = ctx.Students.Find(id);
                return getStudentWithId;
            }
        }

        public static Student DeleteStudent(int id)
        {
            using (var ctx = new Registry())
            {
                Student deleteStudent = ctx.Students.Find(id);
                ctx.Students.Remove(deleteStudent);
                ctx.SaveChanges();
                return deleteStudent;
            }
        }
    }
}
