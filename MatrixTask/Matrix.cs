using VectorTask;

namespace MatrixTask;

public class Matrix
{
    public Vector[] MatrixElements {  get; set; }

    public Matrix(int n, int m)
    {
        //MatrixElements = new Vector(m);
    }

    public Matrix(Matrix matrix)
    {
        MatrixElements = matrix.MatrixElements;
    }

    public Matrix()
    {

    }
}
