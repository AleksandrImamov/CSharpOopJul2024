namespace List;

public class SinglyLinkedList<T>
{
    private ListItem<T>? head;
    private int count;

    public int GetSize()
    {
        return count;
    }

    public T GetFirstElementData()
    {
        if (head == null)
        {
            throw new NullReferenceException("head");
        }

        return head.Data;
    }

    private ListItem<T> GetElementByIndex(int index)
    {
        if (head == null)
        {
            throw new NullReferenceException("head");
        }

        int itemIndex = 0;

        ListItem<T> item = head;

        for (ListItem<T> currentItem = head;
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
        if (head == null)
        {
            throw new NullReferenceException("head");
        }

        if (index == 0)
        {
            head = head.Next;
        }

        ListItem<T> currentItem = GetElementByIndex(index);

        GetElementByIndex(index - 1).Next = GetElementByIndex(index).Next;

        --count;

        return currentItem.Data;
    }

    public void InsertElementAtBeginning(T data)
    {
        ListItem<T> newItem = new ListItem<T>(data, head);

        head = newItem;
        ++count;
    }

    public bool RemoveElementByData(T data)
    {
        if (head == null)
        {
            throw new NullReferenceException("head");
        }

        bool isEquals = false;
        int index = 0;

        for (ListItem<T> item = head; item != null; item = item.Next!)
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
        if (head == null)
        {
            throw new NullReferenceException("head");
        }

        T headData = head.Data;

        head = head.Next;
        --count;

        return headData;
    }

    public void ListReverse()
    {
        if (head == null)
        {
            throw new NullReferenceException("head");
        }

        ListItem<T> prevItem = null!;
        ListItem<T> currentItem = head;
        ListItem<T> nextItem = null!;

        while (currentItem.Next != null)
        {
            nextItem = currentItem.Next;
            currentItem.Next = prevItem;
            prevItem = currentItem;
            currentItem = nextItem;
        }

        currentItem.Next = prevItem;
        head = currentItem;
    }

    public SinglyLinkedList<T> ListCopy()
    {
        if (head == null)
        {
            throw new NullReferenceException("head");
        }

        SinglyLinkedList<T> newList = new SinglyLinkedList<T>();

        ListReverse();

        for (ListItem<T> item = head; item != null; item = item.Next!)
        {
            newList.InsertElementAtBeginning(item.Data);
        }

        ListReverse();

        return newList;
    }
}