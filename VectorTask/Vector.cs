namespace VectorTask;

public class Vector
{
    private double[] _components;

    public Vector(int dimension)
    {
        if (dimension <= 0)
        {
            throw new ArgumentException($"Размерность вектора должна быть > 0, сейчас {dimension}", nameof(dimension));
        }

        _components = new double[dimension];
    }

    public Vector(Vector vector)
    {
        Array.Copy(vector._components, _components, vector._components.Length);
    }

    public Vector(double[] components)
    {
        Array.Copy(components, _components, components.Length);
    }

    public Vector(int dimension, double[] components)
    {
        if (dimension <= 0)
        {
            throw new ArgumentException($"Размерность вектора должна быть > 0, сейчас {dimension}", nameof(dimension));
        }

        if (components.Length <= dimension)
        {
            _components = new double[dimension];

            for (int i = 0; i < components.Length; i++)
            {
                _components[i] = components[i];
            }
        }
        else
        {
            throw new ArgumentException("Длина массива должна быть <= размерности вектора");
        }
    }

    public int GetSize()
    {
        return _components.Length;
    }

    public override string ToString()
    {
        return "{" + String.Join(",", _components) + "}";
    }

    public Vector GetSum(Vector vector)
    {
        double[] resultVectorComponents;

        if (_components.Length < vector._components.Length)
        {
            resultVectorComponents = new double[vector._components.Length];

            for (int i = 0; i < _components.Length; i++)
            {
                resultVectorComponents[i] = _components[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] + vector._components[i];
            }

            return new Vector(resultVectorComponents);
        }

        if (_components.Length > vector._components.Length)
        {
            resultVectorComponents = new double[_components.Length];

            for (int i = 0; i < vector._components.Length; i++)
            {
                resultVectorComponents[i] = vector._components[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] + _components[i];
            }

            return new Vector(resultVectorComponents);
        }

        resultVectorComponents = new double[_components.Length];

        for (int i = 0; i < _components.Length; i++)
        {
            resultVectorComponents[i] = _components[i] + vector._components[i];
        }

        return new Vector(resultVectorComponents);
    }

    public Vector GetDifference(Vector vector)
    {
        double[] resultVectorComponents;

        if (_components.Length < vector._components.Length)
        {
            resultVectorComponents = new double[vector._components.Length];

            for (int i = 0; i < _components.Length; i++)
            {
                resultVectorComponents[i] = _components[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] - vector._components[i];
            }

            return new Vector(resultVectorComponents);
        }

        if (_components.Length > vector._components.Length)
        {
            resultVectorComponents = new double[_components.Length];

            for (int i = 0; i < vector._components.Length; i++)
            {
                resultVectorComponents[i] = vector._components[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = _components[i] - resultVectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        resultVectorComponents = new double[_components.Length];

        for (int i = 0; i < _components.Length; i++)
        {
            resultVectorComponents[i] = _components[i] - vector._components[i];
        }

        return new Vector(resultVectorComponents);
    }

    public Vector GetScalarProduct(int scalar)
    {
        for (int i = 0; i < _components.Length; i++)
        {
            _components[i] *= scalar;
        }

        return new Vector(_components);
    }

    public Vector Reverse()
    {
        for (int i = 0; i < _components.Length; i++)
        {
            _components[i] = _components[i] * (-1);
        }

        return new Vector(_components);
    }

    public double GetLength()
    {
        double powersSum = 0;

        for (int i = 0; i < _components.Length; i++)
        {
            powersSum += Math.Pow(_components[i], 2);
        }

        return Math.Sqrt(powersSum);
    }

    public double this[int index]
    {
        get
        {
            return _components[index];
        }

        set
        {
            _components[index] = value;
        }
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

        if (_components.Length == vector._components.Length)
        {
            for (int i = 0; i < _components.Length; i++)
            {
                if (_components[i] != vector._components[i])
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

        hash = prime * hash + _components.GetHashCode();

        return hash;
    }

    public static Vector GetSum(Vector vector1, Vector vector2)
    {
        double[] resultVectorComponents;

        if (vector1._components.Length < vector2._components.Length)
        {
            resultVectorComponents = new double[vector2._components.Length];

            for (int i = 0; i < vector1._components.Length; i++)
            {
                resultVectorComponents[i] = vector1._components[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] + vector2._components[i];
            }

            return new Vector(resultVectorComponents);
        }

        if (vector1._components.Length > vector2._components.Length)
        {
            resultVectorComponents = new double[vector1._components.Length];

            for (int i = 0; i < vector2._components.Length; i++)
            {
                resultVectorComponents[i] = vector2._components[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] + vector1._components[i];
            }

            return new Vector(resultVectorComponents);
        }

        resultVectorComponents = new double[vector1._components.Length];

        for (int i = 0; i < vector1._components.Length; i++)
        {
            resultVectorComponents[i] = vector1._components[i] + vector2._components[i];
        }

        return new Vector(resultVectorComponents);
    }

    public static Vector GetDifference(Vector vector1, Vector vector2)
    {
        double[] resultVectorComponents;

        if (vector1._components.Length < vector2._components.Length)
        {
            resultVectorComponents = new double[vector2._components.Length];

            for (int i = 0; i < vector1._components.Length; i++)
            {
                resultVectorComponents[i] = vector1._components[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = resultVectorComponents[i] - vector2._components[i];
            }

            return new Vector(resultVectorComponents);
        }

        if (vector1._components.Length > vector2._components.Length)
        {
            resultVectorComponents = new double[vector1._components.Length];

            for (int i = 0; i < vector2._components.Length; i++)
            {
                resultVectorComponents[i] = vector2._components[i];
            }

            for (int i = 0; i < resultVectorComponents.Length; i++)
            {
                resultVectorComponents[i] = vector1._components[i] - resultVectorComponents[i];
            }

            return new Vector(resultVectorComponents);
        }

        resultVectorComponents = new double[vector1._components.Length];

        for (int i = 0; i < vector1._components.Length; i++)
        {
            resultVectorComponents[i] = vector1._components[i] - vector2._components[i];
        }

        return new Vector(resultVectorComponents);
    }

    public static double GetScalarProduct(Vector vector1, Vector vector2, double degrees)
    {
        return Math.Abs(vector1.GetLength()) * Math.Abs(vector2.GetLength()) * Math.Cos((Math.PI / 180) * degrees);
    }
};