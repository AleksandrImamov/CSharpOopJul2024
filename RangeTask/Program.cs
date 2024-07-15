namespace RangeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число диапазона");
            double from = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конечное число диапазона");
            double to = Convert.ToDouble(Console.ReadLine());

            Range range = new Range(from, to);

            Console.WriteLine("Длина диапазона равна : " + range.GetRangeLength());

            Console.WriteLine("Введите любое число");
            double inputNumber = Convert.ToDouble(Console.ReadLine());

            if (range.IsInside(inputNumber))
            {
                Console.WriteLine("Число " + inputNumber + " принадлежит диапазону");
            }
            else
            {
                Console.WriteLine("Число " + inputNumber + " не принадлежит диапазону");
            }

            Console.WriteLine("Введите начальное число диапазона 1");
            double from1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конечное число диапазона 1");
            double to1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите начальное число диапазона 2");
            double from2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конечное число диапазона 2");
            double to2 = Convert.ToDouble(Console.ReadLine());

            Range range1 = new Range(from1, to1, from2, to2);

            Range rangeIntersection = range1.GetRangeIntersection();

            if (rangeIntersection is not null)
            {
                Console.WriteLine("Интервал-пересечение двух интервалов равен " + (rangeIntersection.To - rangeIntersection.From));
            }
            else
            {
                Console.WriteLine("Нет интервала-пересечения");
            }

            Range range2 = new Range(from1, to1, from2, to2);

            Range[] rangeUnion = range2.GetRangeUnion();

            foreach (Range e in rangeUnion)
            {
                Console.WriteLine("Объединение двух интервалов равно" + (e.To - e.From));
            }

            Range range3 = new Range(from1, to1, from2, to2);

            Range[] rangeDifference = range3.GetRangeDifference();

            foreach (Range e in rangeDifference)
            {
                if (rangeDifference is null)
                {
                    Console.WriteLine("Интервалы не пересекаются");
                }

                Console.WriteLine("Разность двух интервалов равна" + (e.To - e.From));
            }
        }
    }
}
