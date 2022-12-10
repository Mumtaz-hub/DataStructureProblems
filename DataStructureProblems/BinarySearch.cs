using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class BinarySearch
    {
        public static int Search(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (key == arr[mid])
                {
                    // We found the target element
                    Console.WriteLine("Found the target element at index {0}", mid);
                    return mid;
                }
                else if (key < arr[mid])
                {
                    // The target element is less than the element at the midpoint,
                    // so we search the left half of the array
                    right = mid - 1;
                }
                else
                {
                    // The target element is greater than the element at the midpoint,
                    // so we search the right half of the array
                    left = mid + 1;
                }
            }

            Console.WriteLine("Target element not found in the array");
            return -1;
        }
    }
}

/*
 * if the given input is sorted, then we can use binary search to find the key in O(log n) time. or two pointers strategy can be used.
 */