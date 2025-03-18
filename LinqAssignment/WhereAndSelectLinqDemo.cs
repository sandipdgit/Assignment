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
            
            Console.WriteLine($"Example {index} : LINQ query using where and select clause to print selected student names where matching age condition");
            Console.WriteLine("");
            Console.WriteLine("OUTPUT : ");

            // Sample list of students
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ram", Age = 32 },
                new Student { Id = 2, Name = "Sandip", Age = 38 },
                new Student { Id = 3, Name = "Krishna", Age = 30 },
                new Student { Id = 4, Name = "Dinesh", Age = 29 },
                new Student { Id = 5, Name = "Santosh", Age = 31 },
                new Student { Id = 6, Name = "Danny", Age = 41 },
                new Student { Id = 7, Name = "David", Age = 35 }
            };

            // LINQ query to filter students older than 29 and select names
            var selectedStudents = students
                .Where(s => s.Age > 29)
                .Select(s => new { s.Name, s.Age });

            // Print results
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student.Name + "\t" + student.Age);
                //Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

        }


    }
}
