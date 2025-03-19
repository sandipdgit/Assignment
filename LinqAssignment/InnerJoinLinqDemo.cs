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

            Console.WriteLine("");
            Console.WriteLine($"Example {index} : Inner Join query using LINQ to print student and their respective matching courses");

            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using extention method syntax style");

            //LINQ Inner Join Using extention method syntax style
            var studentCoursesDemo1 = Student.GetAllStudents().Join(Course.GetAllCourses(), s => s.CourseId, c => c.CourseId, (student, course)
                                 => new
                                 {
                                     StudentName = student.Name,
                                     CourseName = course.CourseName
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

            // LINQ Inner Join Using SQL Like syntax style
            var studentCoursesDemo2 = from student in Student.GetAllStudents()
                                      join course in Course.GetAllCourses()
                                      on student.CourseId equals course.CourseId
                                      select new
                                      {
                                          StudentName = student.Name,
                                          CourseName = course.CourseName
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
