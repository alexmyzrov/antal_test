using System;
using AreaCalculator.Models;
using Xunit;

namespace AreaCalculator.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_CalculatesCircleArea()
        {
            //Arrange
            var circle = new Circle(5);
            
            //Act
            var area = circle.GetArea();
            
            //Assert
            Assert.Equal(78.53982, area, 5);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_RadiusLessOrEqualZero_ThrowsException(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}