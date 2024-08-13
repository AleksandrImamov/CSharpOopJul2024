namespace ShapesTask
{
    internal class PerimeterComparer : IComparer<IShape>
    {
        public int Compare(IShape? shape1, IShape? shape2)
        {
            if (shape1 is null || shape2 is null)
            {
                throw new ArgumentNullException("Неверный параметр");                
            }

            return shape1.GetPerimeter().CompareTo(shape2.GetPerimeter());
        }
    }
}