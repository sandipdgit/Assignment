using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Model
{
    public class LeftJoinLinqDemo
    {

        public static void Example(int index)
        {
            Console.WriteLine("");
            Console.WriteLine($"Example {index} : Left Join query using LINQ to print student and their respective courses");
            
            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using extention method syntax style");

            // LINQ Left Join Using SQL Like syntax style
            var studentCoursesDemo1 = Student.GetAllStudents()
                .GroupJoin(Course.GetAllCourses(), s => s.CourseId, c => c.CourseId, (students, courses) => new
                {
                    students,
                    courses
                })
                .SelectMany(z => z.courses.DefaultIfEmpty(), (a, b) => new
                {
                    StudentName = a.students.Name,
                    CourseName = b == null ? "No Course Assigned" : b.CourseName
                });


            // Print results
            foreach (var sc in studentCoursesDemo1)
            {
                Console.WriteLine(sc.StudentName + "\t" + sc.CourseName);
                //Console.WriteLine($"Student: {sc.StudentName}, Course: {sc.CourseName}");
            }

            Console.WriteLine("----------------------------------------------------------------");



            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using SQL Like syntax style");

            // LINQ Left Join Using SQL Like syntax style
            var studentCoursesDemo2 = from student in Student.GetAllStudents()
                                    join course in Course.GetAllCourses()
                                    on student.CourseId equals course.CourseId
                                    into studentCourseGroup // Group join to handle left join
                                    from course in studentCourseGroup.DefaultIfEmpty() // DefaultIfEmpty ensures Left Join behavior
                                    select new
                                    {
                                        StudentName = student.Name,
                                        CourseName = course != null ? course.CourseName : "No Course Assigned"
                                    };

            // Print results
            foreach (var sc in studentCoursesDemo2)
            {
                Console.WriteLine(sc.StudentName + "\t" + sc.CourseName);
                //Console.WriteLine($"Student: {sc.StudentName}, Course: {sc.CourseName}");
            }

            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
