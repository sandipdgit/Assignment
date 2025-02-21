using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateCharacterExpl
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******** PROGRAM FOR REMOVE DUPLICATE CHARACTER.********");

            SortedList<int, string> programs = new SortedList<int, string>();
            programs.Add(1, "Remove Duplicates Using HashSet");
            programs.Add(2, "Remove Duplicates Using Loop");
            

            foreach (KeyValuePair<int, string> kv in programs)
            {
                Console.WriteLine("Program No : " + kv.Key + " " + kv.Value);
            }

            Console.Write("Please enter program number: ");
            //int inputnum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(programs[1]);

            if (int.TryParse(Console.ReadLine(), out int inputnum) && inputnum > 0) { 
            Console.WriteLine("You have selected program :" + programs[inputnum]);
                switch (inputnum)
                {
                    case 1:
                        RemoveDuplicatesUsingHashSet rmhashset = new RemoveDuplicatesUsingHashSet();
                        break;
                    case 2:
                        RemoveDuplicatesUsingLoop rmloop = new RemoveDuplicatesUsingLoop();
                        break;
                   default:
                        Console.WriteLine("You have entered invalid details");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Please enter valid integer number");
            }
            Console.ReadLine();
            

        }
    }
}
