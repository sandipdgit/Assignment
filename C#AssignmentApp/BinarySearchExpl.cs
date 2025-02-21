using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignmentApp
{
    class BinarySearchExpl
    {

        public BinarySearchExpl()
        {
            try
            {
                Console.WriteLine("******** PROGRAM FOR BINARY SEARCH.********");
                int[] arr = { 1, 3, 5, 7, 9, 11, 13 };  // Should be sorted array 

                //int target = 3;  // Element to be searched
                Console.WriteLine("List of available numbers : " + string.Join(",", arr)); // display in one row
                Console.WriteLine("");

                Console.Write("Please enter any number from available list to search : ");
                int target = Convert.ToInt32(Console.ReadLine());// taking input from console

                int result = BinarySearch(arr, target);

                if (result == -1)
                {
                    Console.WriteLine("Element not found");
                }
                else
                {
                    Console.WriteLine("Element found at index : " + result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Input value is Invalid : " + ex.Message);
            }

        }


        // Binary search method
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;  // Find the middle index

                // Check if target is at mid
                if (arr[mid] == target)
                    return mid;

                // If target is greater, ignore the left half
                if (arr[mid] < target)
                    left = mid + 1;
                // If target is smaller, ignore the right half
                else
                    right = mid - 1;
            }

            // Return -1 if target is not found
            return -1;
        }

    }
}
