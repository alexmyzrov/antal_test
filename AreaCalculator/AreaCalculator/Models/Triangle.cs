using System;

namespace AreaCalculator.Models
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
        
        public bool IsRightTriangle(double tolerance = double.Epsilon)
        {
            throw new NotImplementedException();
        }
    }
}
