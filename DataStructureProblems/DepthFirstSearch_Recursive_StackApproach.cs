using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class DepthFirstSearch_Recursive_Approach
    {
        public static void Search(int[,] arr, int row, int col, int key)
        {
            if (row < 0 || row >= arr.GetLength(0) || col < 0 || col >= arr.GetLength(1))
            {
                // We have reached the end of the array
                return;
            }

            if (arr[row, col] == key)
            {
                // We found the target element
                Console.WriteLine("Found the target element at index {0}, {1}", row, col);
                return;
            }

            // Search the element to the right of the current element
            Search(arr, row, col + 1, key);

            // Search the element below the current element
            Search(arr, row + 1, col, key);
        }
    }

    public class DepthFirstSearch_StackApproach
    {
        public static void Search(int[,] arr, int row, int col, int key)
        {
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            stack.Push(new Tuple<int, int>(row, col));

            while (stack.Count > 0)
            {
                Tuple<int, int> current = stack.Pop();

                if (current.Item1 < 0 || current.Item1 >= arr.GetLength(0) || current.Item2 < 0 || current.Item2 >= arr.GetLength(1))
                {
                    // We have reached the end of the array
                    continue;
                }

                if (arr[current.Item1, current.Item2] == key)
                {
                    // We found the target element
                    Console.WriteLine("Found the target element at index {0}, {1}", current.Item1, current.Item2);
                    return;
                }

                // Search the element to the right of the current element
                stack.Push(new Tuple<int, int>(current.Item1, current.Item2 + 1));

                // Search the element below the current element
                stack.Push(new Tuple<int, int>(current.Item1 + 1, current.Item2));
            }

            Console.WriteLine("Target element not found in the array");
        }
    }

        /*
         *  The depth-first search (DFS) algorithm is a search algorithm that uses a stack data structure to traverse a graph. It begins at the starting node and explores as far as possible along each branch before backtracking.

            To implement DFS using an explicit stack, we can follow these steps:

            Push the starting node onto the stack.
            While the stack is not empty, do the following:
            Pop the top node from the stack.
            If the node is the goal, we are done.
            Otherwise, push all of the node's children onto the stack.
         */
    }
