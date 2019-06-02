using System;

namespace AreaCalculator.Models
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}