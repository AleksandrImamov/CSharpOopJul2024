namespace ShapesTask
{
    internal class Rectangle : IShape
    {
        public double Width {  get; set; }

        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetWidth()
        {
            return Width;
        }

        public double GetHeight()
        {
            return Height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return (Width + Height) * 2;
        }
    }
}