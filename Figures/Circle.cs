using System;

namespace Figures
{
    public class Circle : IFigure
    {
        public Circle(float radius)
        {
            if (radius < 0)
                throw new Exception("radius cannot be negative");
            Radius = radius;
        }

        public double Radius { get; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
