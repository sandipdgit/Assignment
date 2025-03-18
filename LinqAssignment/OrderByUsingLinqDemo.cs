using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Model
{
    public class OrderByUsingLinqDemo
    {

        public static void Example(int index)
        {
            Console.WriteLine($"Example {index} : LINQ query to print Order by students age");
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

            // LINQ query to order students by Age (ascending)
            var orderedStudentsAsc = students.OrderBy(s => s.Age);

            Console.WriteLine("Students ordered by Age (Ascending):");
            foreach (var student in orderedStudentsAsc)
            {
                Console.WriteLine(student.Name + "\t" + student.Age);
                //Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\nStudents ordered by Age (Descending):");

            // LINQ query to order students by Age (descending)
            var orderedStudentsDesc = students.OrderByDescending(s => s.Age);

            foreach (var student in orderedStudentsDesc)
            {
                Console.WriteLine(student.Name + "\t" + student.Age);
                //Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }

    }
}
