using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******** PROGRAM FOR C# ASSIGNMENTS.********");

            SortedList<int, string> programs = new SortedList<int, string>();
            programs.Add(1, "Binary Search");
            programs.Add(2, "Check Palindrome String");
            programs.Add(3, "Factorial Number");
            programs.Add(4, "Fibonacci Series");
            programs.Add(5, "Remove Duplicate Character");
            programs.Add(6, "Reverse Number");


            foreach (KeyValuePair<int, string> kv in programs)
            {
                Console.WriteLine("Program No : " + kv.Key + " " + kv.Value);
            }

            Console.WriteLine("");
            Console.Write("Please enter program number : ");
            
            if (int.TryParse(Console.ReadLine(), out int inputnum) && inputnum > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You have selected program for : " + programs[inputnum].ToUpper());
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");

                switch (inputnum)
                {
                    case 1:
                        BinarySearchExpl bs = new BinarySearchExpl();
                        break;
                    case 2:
                        CheckPalindromeString cps = new CheckPalindromeString();
                        break;
                    case 3:
                        FactorialNumberExpl fact = new FactorialNumberExpl();
                        break;
                    case 4:
                        FibonacciSeriesExpl fs = new FibonacciSeriesExpl();
                        break;
                    case 5:
                        RemoveDuplicateCharacterExpl rdc = new RemoveDuplicateCharacterExpl();
                        break;
                    case 6:
                        ReverseNumberExpl rn = new ReverseNumberExpl();
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
            Console.ReadLine();


        }
    }
}
