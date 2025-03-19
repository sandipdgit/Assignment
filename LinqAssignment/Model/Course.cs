using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public static List<Course> GetAllCourses()
        {
            return new List<Course>()
            {
                new Course { CourseId = 101, CourseName = "Mathematics" },
                new Course { CourseId = 102, CourseName = "Physics" },
                new Course { CourseId = 103, CourseName = "Chemistry" }
            };
        }
    }
}
