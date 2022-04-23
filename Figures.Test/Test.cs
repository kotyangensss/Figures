using System;
using NUnit.Framework;

namespace Figures.Test
{
    public class Test
    {
        private IFigure _triangle;
        private IFigure _circle;

        [Test]
        public void CalculateCircleArea()
        {
            const int radius = 3;
            _circle = new Circle(radius);
            Assert.AreEqual(Math.PI * radius * radius, _circle.CalculateArea());
        }

        [Test]
        public void CalculateZeroCircleArea()
        {
            const int radius = 0;
            _circle = new Circle(radius);
            Assert.AreEqual(0, _circle.CalculateArea());
        }

        [Test]
        public void CreateWrongCircleExceptionThrown()
        {
            const int radius = -1;
            Assert.Catch<Exception>(() => { _circle = new Circle(radius); });
        }

        [Test]
        public void CalculateTriangleArea()
        {
            _triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6.0, _triangle.CalculateArea());
        }

        [Test]
        public void CheckIfTriangleIsRectangular()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }
        
        [Test]
        public void CreateWrongTriangleExceptionThrown()
        {
            Assert.Catch<Exception>(() => { _triangle = new Triangle(1, 2, 3); });
        }
    }
}
