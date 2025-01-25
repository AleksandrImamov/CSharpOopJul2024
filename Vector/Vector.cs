namespace VectorTask;

public class Vector
{
    public double[] VectorComponents { get; set; }

    public Vector(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("Размерность вектора должна быть > 0", nameof(n));
        }

        VectorComponents = new double[n];
    }

    public Vector(Vector vector)
    {
        VectorComponents = vector.VectorComponents;
    }

    public Vector(double[] components)
    {
        VectorComponents = components;
    }

    public Vector(int n, double[] components)
    {
        if (n <= 0)
        {
            throw new ArgumentException("Размерность вектора должна быть > 0", nameof(n));
        }

        if (components.Length <= n)
        {
            VectorComponents = new double[n];

            for (int i = 0; i < components.Length; i++)
            {
                VectorComponents[i] = components[i];
            }
        }
        else
        {
            throw new ArgumentException("Длина массива должна быть <= размерности вектора", nameof(components));
        }
    }

    public int GetSize()
    {
        return VectorComponents.Length;
    }

    public override string ToString()
    {
        return "{" + String.Join(",", VectorComponents) + "}";
    }

    public Vector GetSum(Vector vector)
    {
        double[] resultVectorComponents;

        if (VectorComponents.Length < vector.VectorComponents.Length)
        {
            resultVectorComponents = new double[vector.VectorComponents.Length];

            for (int i = 0; i < VectorComponents.Length; i++)
            {
                resultVectorComponents[i] = VectorComponents[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] + vector.VectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        if (VectorComponents.Length > vector.VectorComponents.Length)
        {
            resultVectorComponents = new double[VectorComponents.Length];

            for (int i = 0; i < vector.VectorComponents.Length; i++)
            {
                resultVectorComponents[i] = vector.VectorComponents[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] + VectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        resultVectorComponents = new double[VectorComponents.Length];

        for (int i = 0; i < VectorComponents.Length; i++)
        {
            resultVectorComponents[i] = VectorComponents[i] + vector.VectorComponents[i];
        }

        return new Vector(resultVectorComponents);
    }

    public Vector GetDifference(Vector vector)
    {
        double[] resultVectorComponents;

        if (VectorComponents.Length < vector.VectorComponents.Length)
        {
            resultVectorComponents = new double[vector.VectorComponents.Length];

            for (int i = 0; i < VectorComponents.Length; i++)
            {
                resultVectorComponents[i] = VectorComponents[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] - vector.VectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        if (VectorComponents.Length > vector.VectorComponents.Length)
        {
            resultVectorComponents = new double[VectorComponents.Length];

            for (int i = 0; i < vector.VectorComponents.Length; i++)
            {
                resultVectorComponents[i] = vector.VectorComponents[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = VectorComponents[i] - resultVectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        resultVectorComponents = new double[VectorComponents.Length];

        for (int i = 0; i < VectorComponents.Length; i++)
        {
            resultVectorComponents[i] = VectorComponents[i] - vector.VectorComponents[i];
        }

        return new Vector(resultVectorComponents);
    }

    public Vector GetScalarProduct(int scalar)
    {
        for (int i = 0; i < VectorComponents.Length; i++)
        {
            VectorComponents[i] *= scalar;
        }

        return new Vector(VectorComponents);
    }

    public Vector Reverse()
    {
        for (int i = 0; i < VectorComponents.Length; i++)
        {
            VectorComponents[i] = VectorComponents[i] * (-1);
        }

        return new Vector(VectorComponents);
    }

    public double GetLength()
    {
        double powersSum = 0;

        for (int i = 0; i < VectorComponents.Length; i++)
        {
            powersSum += Math.Pow(VectorComponents[i], 2);
        }

        return Math.Sqrt(powersSum);
    }

    public double GetComponent(int index)
    {
        return VectorComponents[index];
    }

    public void SetComponent(int index, double value)
    {
        VectorComponents[index] = value;
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

        Vector vector = (Vector)o;

        bool equal = false;

        if (VectorComponents.Length == vector.VectorComponents.Length)
        {
            for (int i = 0; i < VectorComponents.Length; i++)
            {
                if (VectorComponents[i] != vector.VectorComponents[i])
                {
                    return equal;
                }
            }

            equal = true;
        }

        return equal;
    }

    public override int GetHashCode()
    {
        int prime = 37;
        int hash = 1;

        hash = prime * hash + VectorComponents.GetHashCode();

        return hash;
    }

    public static Vector GetSum(Vector vector1, Vector vector2)
    {
        double[] resultVectorComponents;

        if (vector1.VectorComponents.Length < vector2.VectorComponents.Length)
        {
            resultVectorComponents = new double[vector2.VectorComponents.Length];

            for (int i = 0; i < vector1.VectorComponents.Length; i++)
            {
                resultVectorComponents[i] = vector1.VectorComponents[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] + vector2.VectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        if (vector1.VectorComponents.Length > vector2.VectorComponents.Length)
        {
            resultVectorComponents = new double[vector1.VectorComponents.Length];

            for (int i = 0; i < vector2.VectorComponents.Length; i++)
            {
                resultVectorComponents[i] = vector2.VectorComponents[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] + vector1.VectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        resultVectorComponents = new double[vector1.VectorComponents.Length];

        for (int i = 0; i < vector1.VectorComponents.Length; i++)
        {
            resultVectorComponents[i] = vector1.VectorComponents[i] + vector2.VectorComponents[i];
        }

        return new Vector(resultVectorComponents);
    }

    public static Vector GetDifference(Vector vector1, Vector vector2)
    {
        double[] resultVectorComponents;

        if (vector1.VectorComponents.Length < vector2.VectorComponents.Length)
        {
            resultVectorComponents = new double[vector2.VectorComponents.Length];

            for (int i = 0; i < vector1.VectorComponents.Length; i++)
            {
                resultVectorComponents[i] = vector1.VectorComponents[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] - vector2.VectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        if (vector1.VectorComponents.Length > vector2.VectorComponents.Length)
        {
            resultVectorComponents = new double[vector1.VectorComponents.Length];

            for (int i = 0; i < vector2.VectorComponents.Length; i++)
            {
                resultVectorComponents[i] = vector2.VectorComponents[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = vector1.VectorComponents[i] - resultVectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        resultVectorComponents = new double[vector1.VectorComponents.Length];

        for (int i = 0; i < vector1.VectorComponents.Length; i++)
        {
            resultVectorComponents[i] = vector1.VectorComponents[i] - vector2.VectorComponents[i];
        }

        return new Vector(resultVectorComponents);
    }

    public static double GetScalarProduct(Vector vector1, Vector vector2, double degrees)
    {
        return Math.Abs(vector1.GetLength()) * Math.Abs(vector2.GetLength()) * Math.Cos((Math.PI / 180) * degrees);
    }
};