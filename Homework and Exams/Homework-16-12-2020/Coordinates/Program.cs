using System;
using System.Collections.Generic;
using System.Linq;

/*
 Example input:
(5,6, 4,5)
(6,3, 7,3)
(5,6, 2,9)
(7,3, 2,9)
(8,5, 7,3)
(8,5, 4,5)
(0, 0)

Example output:
Successfully added point (5,60, 4,50)!
Successfully added point (6,30, 7,30)!
Successfully added point (5,60, 2,90)!
Successfully added point (7,30, 2,90)!
Successfully added point (8,50, 7,30)!
Successfully added point (8,50, 4,50)!
Points (5,60, 4,50) and (6,30, 7,30) are not lying on a horizontal or a vertical line!
Points (5,60, 4,50) and (5,60, 2,90) are lying on a horizontal or a vertical line!
Points (5,60, 4,50) and (7,30, 2,90) are not lying on a horizontal or a vertical line!
Points (5,60, 4,50) and (8,50, 7,30) are not lying on a horizontal or a vertical line!
Points (5,60, 4,50) and (8,50, 4,50) are lying on a horizontal or a vertical line!
Points (6,30, 7,30) and (5,60, 2,90) are not lying on a horizontal or a vertical line!
Points (6,30, 7,30) and (7,30, 2,90) are not lying on a horizontal or a vertical line!
Points (6,30, 7,30) and (8,50, 7,30) are lying on a horizontal or a vertical line!
Points (6,30, 7,30) and (8,50, 4,50) are not lying on a horizontal or a vertical line!
Points (5,60, 2,90) and (7,30, 2,90) are lying on a horizontal or a vertical line!
Points (5,60, 2,90) and (8,50, 7,30) are not lying on a horizontal or a vertical line!
Points (5,60, 2,90) and (8,50, 4,50) are not lying on a horizontal or a vertical line!
Points (7,30, 2,90) and (8,50, 7,30) are not lying on a horizontal or a vertical line!
Points (7,30, 2,90) and (8,50, 4,50) are not lying on a horizontal or a vertical line!
Points (8,50, 7,30) and (8,50, 4,50) are lying on a horizontal or a vertical line!
 */

namespace Coordinates
{
    class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public override string ToString()
        {
            return $"({this.X:F2}, {this.Y:F2})";
        }
    }

    class Program
    {
        private static List<Point> pts = new List<Point>();

        static void Main(string[] args)
        {
            while (true)
            {
                double[] input = Console.ReadLine()
                    .TrimStart('(')
                    .TrimEnd(')')
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                Point p = new Point(input[0], input[1]);
                if (p.X == 0 && p.Y == 0)
                {
                    break;
                }

                int repeating = pts.FindIndex(t => t.X == p.X && t.Y == p.Y);
                if(repeating != -1)
                {
                    Console.WriteLine($"You can't add point {p}, because it is already added!");
                    continue;
                }

                pts.Add(p);
                Console.WriteLine($"Successfully added point {p}!");
            }

            for(int i = 0; i < pts.Count; i++)
            {
                for(int j = i + 1; j < pts.Count; j++)
                {
                    Console.WriteLine($"Points {pts[i]} and {pts[j]} are {(AreOnLatticeLine(pts[i], pts[j]) ? "" : "not ")}lying on a horizontal or a vertical line!");
                }
            }
        }

        private static bool AreOnLatticeLine(Point p1, Point p2)
        {
            return p1.X == p2.X || p1.Y == p2.Y;
        }
    }
}
