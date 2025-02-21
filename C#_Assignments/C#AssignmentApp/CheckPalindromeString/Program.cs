using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace CheckPalindromeString
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("******** PROGRAM TO TEST PALINDROME.********");
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            
            // Convert to lowercase and remove non-alphanumeric characters
            //string cleanedInput = Regex.Replace(input.ToLower(), @"[^a-z0-9]", "");

            string cleanedInput = input.ToLower();
            char[] arr = cleanedInput.ToCharArray();
            arr = Array.FindAll(arr, char.IsLetterOrDigit);
            cleanedInput = new string(arr);


            // Reverse the cleaned string
            char[] charArray = cleanedInput.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);

            // Compare the cleaned string with its reverse
            return cleanedInput == reversedInput;
        }

      

        // Hint: If you input string like "123454321, madam, racecar" etc which is valid as palindrome and will return true.

    }
}
