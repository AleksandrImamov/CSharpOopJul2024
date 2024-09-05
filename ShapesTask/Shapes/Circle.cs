namespace ShapesTask;

internal class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetWidth()
    {
        return Radius * 2;
    }

    public double GetHeight()
    {
        return Radius * 2;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double GetPerimeter()
    {
        return Math.PI * (Radius * 2);
    }

    public override string ToString()
    {
        return $"Окружность (Радиус: {Radius})";
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

        Circle circle = (Circle)o;

        return Radius == circle.Radius;
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int hash = 1;

        return prime * hash + Radius.GetHashCode();
    }
}