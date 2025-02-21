using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignmentApp
{
    class RemoveDuplicateCharacterExpl
    {

        public RemoveDuplicateCharacterExpl()
        {
            Console.WriteLine("******** PROGRAM FOR REMOVE DUPLICATE CHARACTER.********");
            Console.Write("Please enter a string : ");
            string input = Console.ReadLine();
            string result = RemoveDuplicates(input);
            Console.WriteLine($"String after removing duplicates : {result}");

        }

        static string RemoveDuplicates(string input)
        {
            HashSet<char> hs = new HashSet<char>();
            foreach (char c in input)
            {
                hs.Add(c);
            }

            //return new string(hs.ToArray());
            return String.Join("", hs);
        }


        /*
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
        */

    }


}
