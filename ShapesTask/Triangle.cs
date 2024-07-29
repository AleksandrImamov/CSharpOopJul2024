namespace ShapesTask
{
    internal class Triangle : IShape
    {
        double X1 { get; set; }

        double Y1 { get; set; }

        double X2 { get; set; }

        double Y2 { get; set; }

        double X3 { get; set; }

        double Y3 { get; set; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }

        public double GetWidth()
        {
            return Math.Max(X1, Math.Max(X2, X3)) - Math.Min(X1, Math.Min(X2, X3));
        }

        public double GetHeight()
        {
            return Math.Max(Y1, Math.Max(Y2, Y3)) - Math.Min(Y1, Math.Min(Y2, Y3));
        }

        public double GetArea()
        {
            double segment1Length = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            double segment2Length = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
            double segment3Length = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));

            double semiPerimeter = (segment1Length + segment2Length + segment3Length) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - segment1Length) *
                (semiPerimeter - segment2Length) * (semiPerimeter - segment3Length));
        }

        public double GetPerimeter()
        {
            double segment1Length = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            double segment2Length = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
            double segment3Length = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));

            return segment1Length + segment2Length + segment3Length;
        }
    }
}