namespace List;

public class ListItem<T>
{
    public T Data { get; set; }

    public ListItem<T>? Next { get; set; }

    public ListItem(T data)
    {
        Data = data;
    }

    public ListItem(T data, ListItem<T> next)
    {
        Data = data;
        Next = next;
    }

    public override string ToString()
    {
        return $"({Data})";
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(obj, this))
        {
            return true;
        }

        if (ReferenceEquals(obj, null) || obj.GetType() != GetType())
        {
            return false;
        }

        ListItem<T> listItem = (ListItem<T>)obj;

        return listItem.Data!.Equals(Data);
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int hash = 1;

        hash = prime * hash + Data!.GetHashCode();

        return hash;
    }
}