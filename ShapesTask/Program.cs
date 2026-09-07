namespace ShapesTask.Shapes;

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

        Console.WriteLine(GetShapeWithMaxArea(shapes));
        Console.WriteLine(GetShapeWithSecondPerimeter(shapes));

        Triangle triangle = new Triangle(0, 0, 1, 1, 2, 0);
        double trianglePerimeter = triangle.GetPerimeter();
    }

    public static IShape GetShapeWithMaxArea(IShape[] shapes)
    {
        Array.Sort(shapes, new ShapeAreaComparer());

        return shapes[^1];
    }

    public static IShape GetShapeWithSecondPerimeter(IShape[] shapes)
    {
        Array.Sort(shapes, new ShapePerimeterComparer());

        return shapes[^2];
    }
}