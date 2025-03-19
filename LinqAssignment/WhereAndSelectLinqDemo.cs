using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Model
{
    public class WhereAndSelectLinqDemo
    {

        public static void Example(int index)
        {
            Console.WriteLine("");
            Console.WriteLine($"Example {index} : LINQ query using where and select clause to print selected student names where matching age condition");
            
            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using extention method syntax style");

            // LINQ query to filter students older than 29 and select names
            var selectedStudentsDemo1 = Student.GetAllStudents()
                                        .Where(s => s.Age > 29)
                                        .Select(s => new { s.Name, s.Age });

            // Print results
            foreach (var student in selectedStudentsDemo1)
            {
                Console.WriteLine(student.Name + "\t" + student.Age);
            }


            Console.WriteLine("----------------------------------------------------------------");



            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using SQL Like syntax style");

            // LINQ Inner Join Using SQL Like syntax style
            var selectedStudentsDemo2 = from student in Student.GetAllStudents()
                                        where student.Age > 29
                                        select new
                                        {
                                            StudentName = student.Name,
                                            StudentAge = student.Age
                                        };

            // Print results
            foreach (var student in selectedStudentsDemo2)
            {
                Console.WriteLine(student.StudentName + "\t" + student.StudentAge);
            }

            Console.WriteLine("----------------------------------------------------------------");

        }


    }
}
