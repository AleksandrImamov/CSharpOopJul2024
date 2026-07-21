/*namespace ArrayList;

public class ArrayList<T> : IList<T>
{
    private static int capacity;
    private T[] items = new T[capacity];
    private int count = 0;

    public ArrayList(int capacity, int trimExcess)
    {
        this.capacity = capacity;

    }

    public int Count
    {
        get { return count; }
    }

    public T this[int index]
    {
        get
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException("index");
            }

            return items[index];
        }

        set
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException("index");
            }

            items[index] = value;
        }
    }

    private class TrimExcess
    {
        private int Trim(int arrayCapacity, int count)
        {
            if (((arrayCapacity * 90) / 100) > count)
            {

            }
        }
    }

    public override string ToString()
    {
        return $"[{items}]";
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(obj,this))
        {
            return true ;
        }

        if (ReferenceEquals(obj, null))
        {
            return false ;
        }

        ArrayList<T> list = (ArrayList<T>)obj;

        return list.Count.Equals(Count);
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int hash = 1 ;

        hash = prime * hash + count;
        hash = prime * hash + (items != null ? items.GetHashCode() : 0);

        return hash;
    }

    public int IndexOf(T item)
    {
        return count;
    }
}
*/