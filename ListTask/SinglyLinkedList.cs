namespace ListTask;

public class SinglyLinkedList<T>
{
    public ListItem<T>? Head { get; set; }
    public int Count { get; private set; }

    public int GetSize()
    {
        return Count;
    }

    public T GetFirstElementData()
    {
        if (Head == null)
        {
            throw new NullReferenceException("head");
        }

        return Head.Data;
    }

    private ListItem<T> GetElementByIndex(int index)
    {
        if (Head == null)
        {
            throw new NullReferenceException("head");
        }

        int itemIndex = 0;

        ListItem<T> item = Head;

        for (ListItem<T> currentItem = Head;
            itemIndex <= index && currentItem != null;
            itemIndex++, currentItem = currentItem.Next!)
        {
            item = currentItem;
        }

        return item;
    }

    public T GetDataByIndex(int index)
    {
        ListItem<T> item = GetElementByIndex(index);

        return item.Data;
    }

    public T GetDataByIndex(T data, int index)
    {
        ListItem<T> oldItem = GetElementByIndex(index);

        T oldData = oldItem.Data;

        oldItem.Data = data;

        return oldData;
    }

    public T RemoveElementByIndex(int index)
    {
        if (Head == null)
        {
            throw new NullReferenceException("head");
        }

        if (index == 0)
        {
            Head = Head.Next;
        }

        ListItem<T> currentItem = GetElementByIndex(index);

        GetElementByIndex(index - 1).Next = GetElementByIndex(index).Next;

        --Count;

        return currentItem.Data;
    }

    public void InsertElementAtBeginning(T data)
    {
        ListItem<T> newItem = new ListItem<T>(data, Head);

        Head = newItem;
        ++Count;
    }

    public bool RemoveElementByData(T data)
    {
        if (Head == null)
        {
            throw new NullReferenceException("head");
        }

        bool isEquals = false;
        int index = 0;

        for (ListItem<T> item = Head; item != null; item = item.Next!)
        {
            if (item.Data!.Equals(data))
            {
                RemoveElementByIndex(index);

                isEquals = true;

                break;
            }

            ++index;
        }

        return isEquals;
    }

    public T RemoveBeginningElement()
    {
        if (Head == null)
        {
            throw new NullReferenceException("head");
        }

        T headData = Head.Data;

        Head = Head.Next;
        --Count;

        return headData;
    }

    public void ListReverse()
    {
        if (Head == null)
        {
            throw new NullReferenceException("head");
        }

        ListItem<T> prevItem = null!;
        ListItem<T> currentItem = Head;
        ListItem<T> nextItem = null!;

        while (currentItem.Next != null)
        {
            nextItem = currentItem.Next;
            currentItem.Next = prevItem;
            prevItem = currentItem;
            currentItem = nextItem;
        }

        currentItem.Next = prevItem;
        Head = currentItem;
    }

    public SinglyLinkedList<T> ListCopy()
    {
        if (Head == null)
        {
            throw new NullReferenceException("head");
        }

        SinglyLinkedList<T> newList = new SinglyLinkedList<T>();

        ListReverse();

        for (ListItem<T> item = Head; item != null; item = item.Next!)
        {
            newList.InsertElementAtBeginning(item.Data);
        }

        ListReverse();

        return newList;
    }
}