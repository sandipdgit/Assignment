using LinqAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Program
    {
        /*
            Create sample list and write LINQ query with where and select.
            Create sample lists and write Inner Join query using LINQ. 
            Create sample lists and write left Join query using LINQ. 
            Create sample list and write order by LINQ query.
            Create sample list and write group by LINQ query.
        */


        static void Main(string[] args)
        {

            Console.WriteLine("************* EXAMPLE FOR LINQ QUERIES ASSIGNMENTS *************");
            Console.WriteLine("");

            SortedList<int, string> demo = new SortedList<int, string>();
            demo.Add(1, "Where and Select");
            demo.Add(2, "Inner Join");
            demo.Add(3, "Left Join");
            demo.Add(4, "Order by");
            demo.Add(5, "Group by");



            foreach (KeyValuePair<int, string> kv in demo)
            {
                Console.WriteLine("Example No : " + kv.Key + " - " + kv.Value);
            }

            Console.WriteLine("");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("");
                Console.Write("Please enter example number ( i.e. between 1 to " + demo.Count + ") : ");

                if (int.TryParse(Console.ReadLine(), out int inputnum) && (inputnum > 0 && inputnum <= demo.Count))
                {
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("You have selected example for : " + demo[inputnum].ToUpper());
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("");

                    switch (inputnum)
                    {
                        case 1:
                            WhereAndSelectLinqDemo.Example(inputnum);
                            break;
                        case 2:
                            InnerJoinLinqDemo.Example(inputnum);
                            break;
                        case 3:
                            LeftJoinLinqDemo.Example(inputnum);
                            break;
                        case 4:
                            OrderByUsingLinqDemo.Example(inputnum);
                            break;
                        case 5:
                            GroupByUsingLinqDemo.Example(inputnum);
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("You have entered invalid details");
                            break;


                    }
                }
                else if (inputnum > demo.Count || inputnum == 0)
                {
                    Console.WriteLine("Sorry!! we do not have example with " + inputnum + " number.");

                }
                else
                {
                    Console.WriteLine("Please enter valid integer number");
                }

                Console.WriteLine("");
                Console.WriteLine("");

            } while (1 == 1);
            //NOTE: The condition in the while loop puts the program in an infinite loop.To end the program, simply close the console window.
        }


    }
}
