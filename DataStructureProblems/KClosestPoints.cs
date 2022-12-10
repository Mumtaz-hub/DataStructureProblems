using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    // Structure to represent a point in 2D plane
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    
    public static class KClosestPoints
    {

        // Function to calculate the distance of a point from the origin
        public static double Distance(Point p)
        {
            // use the distance formula to calculate the distance
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }

        public static void FindKClosestPoints()
        {
            // an array of points in 2D plane
            Point[] arr = { new Point(1, 2), new Point(3, 4), new Point(-1, -2),
                            new Point(5, 2), new Point(-1, -1) };

            // number of closest points to the origin
            int k = 2;

            // sort the points in ascending order of their distance
            // from the origin
            var closestPoints = arr.OrderBy(p => Distance(p)).Take(k);
            
            // print the first k closest points
            Console.WriteLine("The {0} closest points are:", k);
            foreach (var p in closestPoints)
                Console.WriteLine("({0}, {1})", p.X, p.Y);
        }

    }
}

/* Explanation
 * This code first defines a Point structure to represent a point in 2D plane, and then defines a function Distance 
 * that calculates the distance of a point from the origin.

In the Main function, we create an array of points, and then use the OrderBy and Take methods to sort the points in ascending order 
of their distance from the origin, and take the first k points. Finally, we print the k closest points.

The Take method is often used in combination with the OrderBy method, which sorts the elements in a sequence 
in ascending order according to a specified key. 

var closestPoints = arr.OrderBy(p => Distance(p)).Take(k);
This code sorts the points in the arr array in ascending order of their distance from the origin,
using the Distance function as the key, and then takes the first k points from the sorted array. 
The resulting sequence of points can then be used to find the k closest points to the origin.

 */
