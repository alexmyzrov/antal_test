using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace AreaCalculator.Models
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            var sides = new[] {a, b, c};

            ValidateSidesAndThrow(sides);
            
            Array.Sort(sides);
            
            _a = sides[0];
            _b = sides[1];
            _c = sides[2];
        }

        public double GetArea()
        {
            var semiPerimeter = (_a + _b + _c) / 2;

            return Math.Sqrt(semiPerimeter
                             * (semiPerimeter - _a)
                             * (semiPerimeter - _b)
                             * (semiPerimeter - _c)
            );
        }
        
        public bool IsRightTriangle(double tolerance = double.Epsilon)
        {
            return Math.Abs(_c * _c - (_a * _a + _b * _b)) < tolerance;
        }

        [AssertionMethod]
        private static void ValidateSidesAndThrow(IReadOnlyList<double> sides)
        {
            if (sides.Any(s => s < double.Epsilon) || !TriangleExists(sides))
            {
                throw new ArgumentException("Invalid triangle side value");
            }
        }

        private static bool TriangleExists(IReadOnlyList<double> sides)
        {
            if (sides[0] > sides[1] + sides[2])
            {
                return false;
            }
            
            if (sides[1] > sides[0] + sides[2])
            {
                return false;
            }
            
            return !(sides[2] > sides[0] + sides[1]);
        }
    }
}
