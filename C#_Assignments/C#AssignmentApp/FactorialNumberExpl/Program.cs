using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumberExpl
{

   //Program for Factorial Number (By calling Recursive Method)
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter non negative integer :");
            //int number = Convert.ToInt32(Console.ReadLine());


            if(int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            //if (number >= 0)
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Please enter valid non negative integer");
            }

            Console.ReadLine();
        }

        static long CalculateFactorial(int num)
        {
            if(num <= 1)
            {
                return 1;
            }else
            {
                return num * CalculateFactorial(num - 1);
            }
        }


    }
    
}
