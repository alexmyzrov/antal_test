using System;
using JetBrains.Annotations;

namespace AreaCalculator.Models
{
    public class Circle: IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            ValidateRadiusAndThrow(radius);
            
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        [AssertionMethod]
        private static void ValidateRadiusAndThrow(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Invalid circle radius value");
            }
        }
    }
}
