namespace ArrayListHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("..\\..\\..\\input.txt");

            List<string> lines = new List<string>();

            string line = reader.ReadLine();

            while (line != null)
            {
                lines.Add(line);

                line = reader.ReadLine();
            }

            Console.WriteLine(string.Join(", ", lines));

            List<int> numbersList = new List<int> { 1, 3, 6, 2, 67, 324, 23, 2, 3, 61, };

            int i = 0;

            while (i < numbersList.Count)
            {
                if (numbersList[i] % 2 == 0)
                {
                    numbersList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(string.Join(", ", numbersList));

            List<int> list = new List<int> { 1, 4, 6, 2, 41, 2, 41, 66, 12 };

            List<int> newList = new List<int>();

            foreach (int number in list)
            {
                if (!newList.Contains(number))
                {
                    newList.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}