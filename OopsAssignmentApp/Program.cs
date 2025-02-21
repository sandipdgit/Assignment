using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("******** EXAMPLE FOR (.NET) OOPS ASSIGNMENTS.********");

            SortedList<int, string> example = new SortedList<int, string>();
            example.Add(1, "Single Inheritance");
            example.Add(2, "MultiLevel Inheritance");
            example.Add(3, "Hierarchical Inheritance");
            example.Add(4, "Static Or CompileTime Polymorphism");
            example.Add(5, "Dynamic Or Runtime Polymorphism");
           

            foreach (KeyValuePair<int, string> kv in example)
            {
                Console.WriteLine("Example No : " + kv.Key + " " + kv.Value);
            }

            Console.WriteLine("");
            Console.Write("Please enter example number : ");

            if (int.TryParse(Console.ReadLine(), out int inputnum) && inputnum > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You have selected example for : " + example[inputnum].ToUpper());
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");

                switch (inputnum)
                {
                    case 1:
                        SingleInheritance.Print(inputnum);
                        break;
                    case 2:
                        MultilevelInheritance.Print(inputnum);
                        break;
                    case 3:
                        HierarchicalInheritance.Print(inputnum);
                        break;
                    case 4:
                        StaticOrCompileTimePolymorphism.Print(inputnum);
                        break;
                    case 5:
                        DynamicOrRuntimePolymorphism.Print(inputnum);
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("You have entered invalid details");
                        break;


                }
            }
            else
            {
                Console.WriteLine("Please enter valid integer number");
            }
            Console.WriteLine("");
            Console.ReadLine();


        }
    }
}
