using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamTask7
{
    public static class CourseHelpers
    {
        public static Course AddCourse(string courseName)
        {
            using (var ctx = new Registry())
            {
                Course newCourse = new Course();
                newCourse.CourseName = courseName;

                ctx.Courses.Add(newCourse);
                ctx.SaveChanges();
                return newCourse;
            }
        }
    }
}
