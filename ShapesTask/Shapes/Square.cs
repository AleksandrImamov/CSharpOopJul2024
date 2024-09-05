namespace ShapesTask;

internal class Square : IShape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public double GetWidth()
    {
        return SideLength;
    }

    public double GetHeight()
    {
        return SideLength;
    }

    public double GetArea()
    {
        return SideLength * SideLength;
    }

    public double GetPerimeter()
    {
        return SideLength * 4;
    }

    public override string ToString()
    {
        return $"Квадрат (Длина стороны: {SideLength})";
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

        return SideLength == square.SideLength;
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int hash = 1;

        return prime * hash + SideLength.GetHashCode();
    }
}