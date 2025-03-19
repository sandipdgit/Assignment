using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public int CourseId { get; set; }

        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { Id = 1, Name = "Ram", Age = 32, Department = "Computer Science", CourseId = 101},
                new Student { Id = 2, Name = "Sandip", Age = 38, Department = "Mathematics", CourseId = 102},
                new Student { Id = 3, Name = "Krishna", Age = 30, Department = "Computer Science", CourseId = 101},
                new Student { Id = 4, Name = "Dinesh", Age = 29, Department = "Physics", CourseId = 103},
                new Student { Id = 5, Name = "Santosh", Age = 31, Department = "Mathematics", CourseId = 105},
                new Student { Id = 6, Name = "Danny", Age = 33, Department = "Physics", CourseId = 104},
                new Student { Id = 7, Name = "David", Age = 35, Department = "Physics", CourseId = 104}
            };
        }


    }
}
