using System;
using System.ComponentModel.DataAnnotations;

namespace Figures
{
    public class Triangle : IFigure
    {
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
                throw new Exception("length of side cannot be negative");
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side3 + side2 <= side1)
                throw new Exception("the triangle inequality does not hold");
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public double CalculateArea()
        {
            var p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public bool IsRectangular()
        {
            return 2 * Math.Pow(Math.Max(Side1, Math.Max(Side2, Side3)), 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2) + Math.Pow(Side3, 2);
        }
    }
}