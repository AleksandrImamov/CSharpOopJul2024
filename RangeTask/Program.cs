namespace RangeTask;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите начальное число интервала:");
        double from1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите конечное число интервала:");
        double to1 = Convert.ToDouble(Console.ReadLine());

        Range range1 = new Range(from1, to1);

        Console.WriteLine("Длина интервала равна: " + range1.GetLength());

        Console.WriteLine("Введите любое число:");
        double number = Convert.ToDouble(Console.ReadLine());

        if (range1.IsInside(number))
        {
            Console.WriteLine("Число " + number + " принадлежит интервалу");
        }
        else
        {
            Console.WriteLine("Число " + number + " не принадлежит интервалу");
        }

        Console.WriteLine("Введите начальное число интервала 1:");
        from1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите конечное число интервала 1:");
        to1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите начальное число интервала 2:");
        double from2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите конечное число интервала 2:");
        double to2 = Convert.ToDouble(Console.ReadLine());

        range1 = new Range(from1, to1);

        Range range2 = new Range(from2, to2);

        Range? intersection = range1.GetIntersection(range2);

        if (intersection is not null)
        {
            Console.WriteLine("Интервал-пересечение двух интервалов равен: " + intersection);
        }
        else
        {
            Console.WriteLine("Нет интервала-пересечения");
        }

        Range[] union = range1.GetUnion(range2);

        if (union.Length == 1)
        {
            Console.WriteLine("Объединение двух интервалов равно : " + union[0]);
        }
        else
        {
            Console.WriteLine("Интервалы не пересекаются: ");

            foreach (Range range in union)
            {
                Console.WriteLine(range);
            }
        }

        Range[] difference = range1.GetDifference(range2);

        if (difference.Length == 0)
        {
            Console.WriteLine("Разность двух интервалов не определена.");
        }
        else
        {
            Console.WriteLine("Разность двух интервалов равна: ");

            foreach (Range range in difference)
            {
                Console.WriteLine(range);
            }
        }
    }
}