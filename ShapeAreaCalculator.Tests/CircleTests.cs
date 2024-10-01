using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            double area = AreaCalculator.CalculateArea(circle);
            Assert.Equal(78.53981633974483, area, 5);
        }
    }
}
