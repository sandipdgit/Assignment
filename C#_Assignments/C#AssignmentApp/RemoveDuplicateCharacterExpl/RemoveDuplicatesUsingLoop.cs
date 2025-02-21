using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateCharacterExpl
{
    class RemoveDuplicatesUsingLoop
    {

        public RemoveDuplicatesUsingLoop()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string result = RemoveDuplicates(input);
            Console.WriteLine($"String after removing duplicates: {result}");
        }

        static string RemoveDuplicates(string input)
        {
            string result = string.Empty;
            foreach (char c in input)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }



    }
}
