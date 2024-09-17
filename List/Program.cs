namespace List;

internal class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.InsertElementAtBeginning(5);
        list.InsertElementAtBeginning(4);
        list.InsertElementAtBeginning(3);
        list.InsertElementAtBeginning(2);
        list.InsertElementAtBeginning(1);

        Console.WriteLine(list.GetSize());
        Console.WriteLine(list.RemoveElementByIndex(4));
        Console.WriteLine(list.RemoveBeginningElement());

        SinglyLinkedList<int> newList = list.ListCopy();

        Console.WriteLine(list.RemoveElementByData(11));
        Console.WriteLine(list.GetDataByIndex(15, 0));
        Console.WriteLine(list.GetDataByIndex(2));
        Console.WriteLine(list.RemoveElementByIndex(4));
    }
}