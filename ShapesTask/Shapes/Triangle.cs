namespace ShapesTask;

internal class Triangle : IShape
{
    public double X1 { get; set; }

    public double Y1 { get; set; }

    public double X2 { get; set; }

    public double Y2 { get; set; }

    public double X3 { get; set; }

    public double Y3 { get; set; }

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

    private double GetSegment1Length()
    {
        return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    }

    private double GetSegment2Length()
    {
        return Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
    }

    private double GetSegment3Length()
    {
        return Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
    }

    public double GetArea()
    {
        double semiPerimeter = (GetSegment1Length() + GetSegment2Length() + GetSegment3Length()) / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - GetSegment1Length()) *
            (semiPerimeter - GetSegment2Length()) * (semiPerimeter - GetSegment3Length()));
    }

    public double GetPerimeter()
    {
        return GetSegment1Length() + GetSegment2Length() + GetSegment3Length();
    }

    public override string ToString()
    {
        return $"Треугольник (X1: {X1}, Y1: {Y1}, X2: {X2}, Y2: {Y2}, X3: {X3}, Y3: {Y3})";
    }

    public override bool Equals(object? o)
    {
        if (ReferenceEquals(o, this))
        {
            return true;
        }

        if (ReferenceEquals(o, null) || o.GetType != GetType)
        {
            return false;
        }

        Triangle triangle = (Triangle)o;

        return X1 == triangle.X1 && Y1 == triangle.Y1 &&
            X2 == triangle.X2 && Y2 == triangle.Y2 &&
            X3 == triangle.X3 && Y3 == triangle.Y3;
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int hash = 1;

        hash = prime * hash + X1.GetHashCode();
        hash = prime * hash + Y1.GetHashCode();
        hash = prime * hash + X2.GetHashCode();
        hash = prime * hash + Y2.GetHashCode();
        hash = prime * hash + X3.GetHashCode();

        return prime * hash + Y3.GetHashCode();
    }
}