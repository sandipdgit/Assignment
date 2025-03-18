using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Model
{
    public class InnerJoinLinqDemo
    {

        public static void Example(int index)
        {

            Console.WriteLine($"Example {index} : Inner Join query using LINQ to print student and their respective matching courses");
            Console.WriteLine("");
            Console.WriteLine("OUTPUT : ");

            // Sample list of students
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ram", Age = 32, Department = "Computer Science", CourseId = 101},
                new Student { Id = 2, Name = "Sandip", Age = 38, Department = "Mathematics", CourseId = 102},
                new Student { Id = 3, Name = "Krishna", Age = 30, Department = "Computer Science", CourseId = 101},
                new Student { Id = 4, Name = "Dinesh", Age = 29, Department = "Physics", CourseId = 103},
                new Student { Id = 5, Name = "Santosh", Age = 31, Department = "Mathematics", CourseId = 105}, 
                new Student { Id = 6, Name = "Danny", Age = 33, Department = "Physics", CourseId = 104},
                new Student { Id = 7, Name = "David", Age = 35, Department = "Physics", CourseId = 104}
            };

            // Sample list of courses
            List<Course> courses = new List<Course>
            {
                new Course { CourseId = 101, CourseName = "Mathematics" },
                new Course { CourseId = 102, CourseName = "Physics" },
                new Course { CourseId = 103, CourseName = "Chemistry" }
            };

            // LINQ Inner Join
            var studentCourses = from student in students
                                 join course in courses
                                 on student.CourseId equals course.CourseId
                                 select new
                                 {
                                     StudentName = student.Name,
                                     CourseName = course.CourseName
                                 };

            // Print results
            foreach (var sc in studentCourses)
            {

                Console.WriteLine(sc.StudentName + "\t" + sc.CourseName);
                //Console.WriteLine($"Student: {sc.StudentName}, Course: {sc.CourseName}");
            }
        }


    }
}
