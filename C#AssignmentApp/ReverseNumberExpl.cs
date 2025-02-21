using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignmentApp
{
    class ReverseNumberExpl
    {

        public ReverseNumberExpl()
        {
            try
            {
                Console.WriteLine("******** PROGRAM FOR REVERSE NUMBER.********");
                Console.Write("Please enter numeric string : ");// for example 123456
               
                //int number = Convert.ToInt32(Console.ReadLine());
                bool isOk = int.TryParse(Console.ReadLine(), out int number);

                if (isOk)
                {
                    int reverseNumber = ReverseNumber(number);
                    Console.WriteLine("OUTPUT :: ");
                    Console.Write($"After reverse number is : {reverseNumber}");
                    
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter valid integer number ");
                
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured!!.  " + ex.Message);
                Console.WriteLine("");
            }

        }


        static int ReverseNumber(int num)
        {

            int reverse = 0;
            while (num != 0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num /= 10;

            }

            return reverse;

        }

    }
}
