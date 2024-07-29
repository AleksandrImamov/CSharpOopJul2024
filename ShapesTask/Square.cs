namespace ShapesTask
{
    internal class Square : IShape
    {
        public double SideLenth { get; set; }

        public Square(double sideLength)
        {
            SideLenth = sideLength;
        }

        public double GetWidth()
        {
            return SideLenth;
        }

        public double GetHeight()
        {
            return SideLenth;
        }

        public double GetArea()
        {
            return SideLenth * SideLenth;
        }

        public double GetPerimeter()
        {
            return SideLenth * 4;
        }
    }
}