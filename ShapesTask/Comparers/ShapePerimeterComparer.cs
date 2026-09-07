namespace ShapesTask.Shapes;

internal class ShapePerimeterComparer : IComparer<IShape>
{
    public int Compare(IShape? shape1, IShape? shape2)
    {
        if (shape1 is null)
        {
            throw new ArgumentNullException("shape1");
        }

        if (shape2 is null)
        {
            throw new ArgumentNullException("shape2");
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