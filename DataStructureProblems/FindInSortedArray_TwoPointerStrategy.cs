using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class FindInSortedArray_TwoPointerStrategy
    {
        public static int[] Find(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];

                if (sum == key)
                {
                    // We found the target element
                    Console.WriteLine("Found the target element at index {0} and {1}", left, right);
                    return new int[] { left, right };
                }
                else if (key < sum)
                {
                    // The target element is less than the element at the midpoint,
                    // so we search the left half of the array
                    right--;
                }
                else
                {
                    // The target element is greater than the element at the midpoint,
                    // so we search the right half of the array
                    left++;
                }
            }

            Console.WriteLine("Target element not found in the array");
            return new int[] { -1, -1 };
        }
    }
}

/*
 *  find a pair of elements in a sorted array that sum to a given value: Two pointer strategy used
 *  In each iteration of the loop, the program calculates the sum of the elements at the left and right pointers and checks 
 *  if it is equal to the target sum. If it is, the program prints out the pair of elements and breaks out of the loop. 
 *  If the current sum is less than the target sum, the program moves the left pointer to the right to try a larger pair of elements. 
 *  If the current sum is greater than the target sum, the program moves the right pointer to the left to try a smaller pair of elements.
 */