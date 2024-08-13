namespace ShapesTask;

internal class Program
{
    static void Main(string[] args)
    {
        IShape[] shapes = { new Rectangle(5, 5), new Rectangle(2, 1), new Square(88), new Circle(23), new Triangle(0, 0, 5, 5, 0, 10) };

        Console.WriteLine(GetShapesArea(shapes));
        Console.WriteLine(GetShapesPerimeter(shapes));
    }

    public static IShape GetShapesArea(IShape[] shapes)
    {
        Array.Sort(shapes);

        int maxShapeIndex = shapes.Length - 1;

        return shapes[maxShapeIndex];
    }

    public static IShape GetShapesPerimeter(IShape[] shapes)
    {
        Array.Sort(shapes, new PerimeterComparer());

        int maxShapeIndex = shapes.Length - 2;

        return shapes[maxShapeIndex];
    }
}