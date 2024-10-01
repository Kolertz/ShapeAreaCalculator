namespace ShapeAreaCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = AreaCalculator.CalculateArea(triangle);
            Assert.Equal(6, area, 5);
        }

        [Fact]
        public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void IsRightAngled_NonRightAngledTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(2, 2, 3);
            Assert.False(triangle.IsRightAngled());
        }

        [Fact]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }
    }
}