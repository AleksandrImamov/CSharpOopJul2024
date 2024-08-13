namespace ShapesTask;

internal class Rectangle : IShape, IComparable
{
    public double Width { get; set; }

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

    public override string ToString()
    {
        return $"({Width}, {Height})";
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

        Rectangle rectangle = (Rectangle)o;

        return Width == rectangle.Width && Height == rectangle.Height;
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int hash = 1;

        hash = prime * hash + Width.GetHashCode();
        hash = prime * hash + Height.GetHashCode();

        return hash;
    }

    public int CompareTo(object? o)
    {
        if (o is IShape shape)
        {
            return GetArea().CompareTo(shape.GetArea());

        }

        throw new ArgumentNullException("Неверные параметры");
    }
}