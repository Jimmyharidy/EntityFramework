using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamTask7
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; } 
    }
}
