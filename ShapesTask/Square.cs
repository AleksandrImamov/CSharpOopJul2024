namespace ShapesTask;

internal class Square : IShape, IComparable
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

    public override string ToString()
    {
        return $"({SideLenth})";
    }

    public override bool Equals(object? o)
    {
        if (ReferenceEquals(o, this))
        {
            return true;
        }

        if (ReferenceEquals(o, null) || o.GetType() != GetType())
        {
            return false;
        }

        Square square = (Square)o;

        return SideLenth == square.SideLenth;
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int hash = 1;

        return hash = prime * hash + SideLenth.GetHashCode();
    }

    public int CompareTo(object? o)
    {
        if (o is IShape shape)
        {
            return GetArea().CompareTo(shape.GetArea());

        }

        throw new ArgumentNullException("Неверный параметр");
    }
}