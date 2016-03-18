using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamTask7
{
    class Application
    {
        public void StartMenu()
        {
            Console.WriteLine("1. Add a student");
            Console.WriteLine("2. Add a course");
            Console.WriteLine("3. Delete a student");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Please enter a first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter a last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Please enter a age");
                int age = int.Parse(Console.ReadLine());

                Student addNewStudent = StudentHelpers.AddAStudent(firstName, lastName, age);
                Console.WriteLine("New student added:" + " " + addNewStudent.FirstName + " " + addNewStudent.LastName + " " + addNewStudent.Age + " ID: " + addNewStudent.StudentId);
            }
            if (choice == "2")
            {
                Console.WriteLine("Please enter the course name you want to add: ");
                string courseName = Console.ReadLine();

                Course addNewCourse = CourseHelpers.AddCourse(courseName);
                Console.WriteLine("New course added:" + " " + addNewCourse.CourseName + " ID:" + addNewCourse.CourseId);
            }
            if (choice == "3")
            {
                Console.WriteLine("Please search for a student to delete:");
                string searchText = Console.ReadLine();
                List<Student> studentSearch = StudentHelpers.SearchForAStudent(searchText);

                foreach (Student student in studentSearch)
                {
                    Console.WriteLine("Search Result:" + " " + student.FirstName + " " + student.LastName + " " + student.Age + " ID " + student.StudentId);
                }
                Console.WriteLine("Please enter the id for the student you want to delete:");
                int studentId = int.Parse(Console.ReadLine());
                Student deleteStudent = StudentHelpers.DeleteStudent(studentId);
                Console.WriteLine("Student deleted from the system...");
            }
        }
    }
}
