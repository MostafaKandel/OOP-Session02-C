using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session02_C
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }


        // Constructor
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        // Methods
        public override string ToString()
        {
            return $"Point({X}, {Y})";
        }
        public static double CaluculateDistance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
