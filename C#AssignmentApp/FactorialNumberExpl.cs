using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignmentApp
{
    class FactorialNumberExpl
    {

        public FactorialNumberExpl()
        {
            Console.WriteLine("******** PROGRAM FOR FACTORIAL NUMBER.********");
            Console.Write("Enter non negative integer :");
            //int number = Convert.ToInt32(Console.ReadLine());


            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            //if (number >= 0)
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is : {factorial}");
            }
            else
            {
                Console.WriteLine("Please enter valid non negative integer");
            }

            Console.ReadLine();
        }


        static long CalculateFactorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            else
            {
                return num * CalculateFactorial(num - 1);
            }
        }


        /*
        // Using For Loop
        static long CalculateFactorial(int num)
        {
            long factorial = 1;
            for(int i = num; i > 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
        */

        //Hint : For calculating factorial number If you enter 5 (i.e n = 5) then it will calcualte like 5!= 5 * 4 * 3 * 2 * 1 and give output "120"

    }
}
