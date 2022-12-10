using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class NQueenproblem
    {
        static int n = 4;
        static int[] queens = new int[n];

        static bool IsValid(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                // Check if any queens are placed on the same column
                if (queens[i] == col)
                {
                    return false;
                }

                // Check if any queens are placed on the same diagonal
                if (Math.Abs(queens[i] - col) == Math.Abs(i - row))
                {
                    return false;
                }
            }

            return true;
        }

       public  static void PlaceQueens(int row)
        {
            if (row == n)
            {
                // All queens have been placed
                Console.WriteLine(string.Join(", ", queens.Select(x => x + 1)));
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsValid(row, col))
                {
                    queens[row] = col;
                    PlaceQueens(row + 1);
                }
            }
        }

    }
}

/*
 * Backtracking is a search algorithm that explores a set of possibilities incrementally, each time choosing the next option 
 * based on the current state of the search. The algorithm continues to search through the possibilities until it finds a solution 
 * or determines that there is no solution. If a solution is not found, the algorithm "backtracks" and undoes the last step in the search,
 * then tries a different option. This process continues until a solution is found or it is determined that there are no solutions.

Backtracking algorithms are often used to solve constraint satisfaction problems, where the goal is to find a set of values that satisfy 
a given set of constraints. These algorithms are useful because they can quickly eliminate impossible solutions, allowing the search to 
focus on only the most promising possibilities.

For example, a common use of backtracking is to solve problems like the "n-queens problem," where the goal is to place n queens on 
an n-by-n chessboard in such a way that no two queens are attacking each other. A backtracking algorithm can be used to try all possible 
placements of the queens, quickly eliminating any placements that are not valid. This allows the algorithm to find a solution to the problem 
much more quickly than if it had to search through all possible placements of the queens without any pruning.
 */