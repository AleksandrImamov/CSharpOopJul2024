namespace ShapesTask;

internal class ShapePerimeterComparer : IComparer<IShape>
{
    public int Compare(IShape? shape1, IShape? shape2)
    {
        if (shape1 is null || shape2 is null)
        {
            throw new ArgumentNullException("Неверный параметр");
        }

        if (shape1.GetPerimeter() > shape2.GetPerimeter())
        {
            return 1;
        }

        if (shape1.GetPerimeter() < shape2.GetPerimeter())
        {
            return -1;
        }

        return 0;
    }
}