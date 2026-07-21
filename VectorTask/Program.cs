namespace VectorTask;

internal class Program
{
    static void Main(string[] args)
    {
        Vector vector1 = new Vector([31, 5, 422]);

        Vector vector2 = new Vector([43, 15]);

        vector1[1] = 123;

        Console.WriteLine(vector1[1]);

        try
        {
            Vector vector3 = new Vector(0);

            Console.WriteLine(vector3);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }

        try
        {
            Vector vector4 = new Vector(2, [1, 3]);

            Console.WriteLine(vector4);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine(Vector.GetSum(vector1, vector2));

        Console.WriteLine($"{Vector.GetScalarProduct(vector1, vector2, 30):f2}");

        Console.WriteLine(vector1.GetHashCode());

        Console.WriteLine(vector2.GetHashCode());

        Console.WriteLine(vector1.Equals(vector2));

        Console.WriteLine(vector1.Reverse());

        Console.WriteLine($"{vector2.GetLength():f2}");        

        Console.WriteLine(vector1);
    }
}