using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment.Model
{
    public class GroupByUsingLinqDemo
    {

        public static void Example(int index)
        {
            Console.WriteLine("");
            Console.WriteLine($"Example {index} : Group by LINQ query to print each department and the students");

            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using extention method syntax style");

            // LINQ GroupBy query to group students by Department
            var groupedStudentsDemo1 = Student.GetAllStudents().GroupBy(s => s.Department);

            // Print grouped results
            foreach (var group in groupedStudentsDemo1)
            {
                Console.WriteLine($"Department: {group.Key}");
               
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name + "\t" + student.Age );
                }

                Console.WriteLine();
            }



            Console.WriteLine("----------------------------------------------------------------");



            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using SQL Like syntax style");

            // LINQ GroupBy query to group students by Department
            var groupedStudentsDemo2 = from student in Student.GetAllStudents()
                                       group student by student.Department;

            // Print grouped results
            foreach (var group in groupedStudentsDemo2)
            {
                Console.WriteLine($"Department: {group.Key}");

                foreach (var student in group)
                {
                    Console.WriteLine(student.Name + "\t" + student.Age);
                }

                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
