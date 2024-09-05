namespace ShapesTask;

internal class Program
{
    static void Main(string[] args)
    {
        IShape[] shapes =
        {
            new Rectangle(5, 5),
            new Rectangle(2, 1),
            new Square(88),
            new Circle(23),
            new Triangle(0, 0, 5, 5, 0, 10)
        };

        Console.WriteLine(GetShapeWithMaximumArea(shapes));
        Console.WriteLine(GetShapeWithSecondPerimeter(shapes));
    }

    public static IShape GetShapeWithMaximumArea(IShape[] shapes)
    {
        Array.Sort(shapes, new ShapeAreaComparer());

        return shapes[shapes.Length - 1];
    }

    public static IShape GetShapeWithSecondPerimeter(IShape[] shapes)
    {
        Array.Sort(shapes, new ShapePerimeterComparer());

        return shapes[shapes.Length - 2];
    }
}