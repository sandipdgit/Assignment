using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateCharacterExpl
{
    class RemoveDuplicatesUsingHashSet
    {

      public RemoveDuplicatesUsingHashSet() 
      { 
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string result = RemoveDuplicates(input);
            Console.WriteLine($"String after removing duplicates: {result}");
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
    }



}
