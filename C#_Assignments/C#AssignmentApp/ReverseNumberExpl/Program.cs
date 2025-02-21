using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberExpl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("******** PROGRAM FOR REVERSE NUMBER.********");
                Console.Write("Please enter number string: ");// for example 123456
                //int number = Convert.ToInt32(Console.ReadLine());

                if(int.TryParse(Console.ReadLine(), out int number)){ 
                    int reverseNumber = ReverseNumber(number);
                    Console.Write($"Reverse number is : {reverseNumber}");
                }
                else
                {
                    Console.Write("Please enter valid integer number ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured!!.  " + ex.Message);
            }

        }

        static int ReverseNumber(int num)
        {

            int reverse = 0;
            while(num != 0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num /= 10;

            }

            return reverse;

        }
    }
}
