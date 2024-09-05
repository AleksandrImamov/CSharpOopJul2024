namespace ShapesTask;

internal class ShapeAreaComparer : IComparer<IShape>
{
    public int Compare(IShape? shape1, IShape? shape2)
    {
        if (shape1 is null)
        {
            throw new ArgumentNullException();
        }
        if (shape2 is null)
        {
            throw new ArgumentNullException();
        }

        if (shape1.GetArea() > shape2.GetArea())
        {
            return 1;
        }

        if (shape1.GetArea() < shape2.GetArea())
        {
            return -1;
        }

        return 0;
    }
}
