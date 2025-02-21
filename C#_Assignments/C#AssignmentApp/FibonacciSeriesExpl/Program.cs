using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesExpl
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("******** PROGRAM FOR FIBONACCI SERIES.********");

            Console.Write("Enter the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            Console.Write("Fibonacci Series:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //Hint : If you enter 5 (i.e n = 5) then it will give output "0 1 1 2 3"
    }
}
