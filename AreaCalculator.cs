namespace ShapeAreaCalculator
{
    public static class AreaCalculator
    {
        public static double CalculateArea<T>(T shape) where T : IShape
        {
            return shape.CalculateArea();
        }
    }
}
