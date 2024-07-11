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
        }
    }
}
