using System;
using AreaCalculator.Models;
using Xunit;

namespace AreaCalculator.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_CalculatesTriangleArea()
        {
            //Arrange
            var triangle = new Triangle(3.00001, 4.00001, 5.00001);
            
            //Act
            var area = triangle.GetArea();
            
            //Assert
            Assert.Equal(6.00004, area, 5);
        }
        
        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void Constructor_WrongSideValue_ThrowsException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
        
        [Fact]
        public void Constructor_TriangleImpossible_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 6, 100));
        }
        
        [Fact]
        public void IsRightTriangle_TriangleIsRight_True()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);
            
            //Act
            var isRightTriangle = triangle.IsRightTriangle();
            
            //Assert
            Assert.True(isRightTriangle);
        }
        
        [Fact]
        public void IsRightTriangle_TriangleIsNOTRight_False()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 6);
            
            //Act
            var isRightTriangle = triangle.IsRightTriangle();
            
            //Assert
            Assert.False(isRightTriangle);
        }
    }
}