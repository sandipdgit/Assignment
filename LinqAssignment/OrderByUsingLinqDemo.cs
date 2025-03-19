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
            Console.WriteLine("");
            Console.WriteLine($"Example {index} : LINQ query to print Order by students age");
            
            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using extention method syntax style");
           
           // LINQ query to order students by Age (ascending)
            var orderedStudentsAsc = Student.GetAllStudents().OrderBy(s => s.Age);

            Console.WriteLine("Students ordered by Age (Ascending):");
            foreach (var student in orderedStudentsAsc)
            {
                Console.WriteLine(student.Name + "\t" + student.Age);
            }

            Console.WriteLine("\nStudents ordered by Age (Descending):");

            // LINQ query to order students by Age (descending)
            var orderedStudentsDesc = Student.GetAllStudents().OrderByDescending(s => s.Age);

            foreach (var student in orderedStudentsDesc)
            {
                Console.WriteLine(student.Name + "\t" + student.Age);
            }

            Console.WriteLine("----------------------------------------------------------------");



            Console.WriteLine("");
            Console.WriteLine("OUTPUT : Using SQL Like syntax style");

            // LINQ query to order students by Age (ascending)
            var orderedStudentsAscDemo2 = from student in Student.GetAllStudents()
                                          orderby student.Name
                                          select student;


            Console.WriteLine("Students ordered by Age (Ascending):");
            foreach (var student in orderedStudentsAscDemo2)
            {
                Console.WriteLine(student.Name + "\t" + student.Age);
                //Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("\nStudents ordered by Age (Descending):");

            // LINQ query to order students by Age (descending)
            var orderedStudentsDescDemo2 = from student in Student.GetAllStudents()
                                           orderby student.Name descending
                                           select student;

            foreach (var student in orderedStudentsDescDemo2)
            {
                Console.WriteLine(student.Name + "\t" + student.Age);
                //Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

            Console.WriteLine("----------------------------------------------------------------");
        }

    }
}
