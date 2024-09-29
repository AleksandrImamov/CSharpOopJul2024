namespace LambdaExspression;

internal class Program
{
    static void Main(string[] args)
    {
        var persons = new List<Person>
        {
            new Person("Петр", 22),
            new Person("Иван", 10),
            new Person("Сергей", 35),
            new Person("Андрей", 14),
            new Person("Александр", 19),
            new Person("Михаил", 69),
            new Person("Александр", 8),
            new Person("Владимир", 13),
            new Person("Андрей", 39),
            new Person("Виктор", 84)
        };

        var allUniqueNames = persons.Select(p => p.Name).Distinct().ToList();

        Console.WriteLine("Имена: " + string.Join(", ", allUniqueNames));

        Console.WriteLine("Младше 18 лет: " + string.Join(", ", persons.Where(p => p.Age < 18)));

        Console.WriteLine("Их средний возраст: " + persons.Where(p => p.Age < 18).Average(p => p.Age));

        Dictionary<string, double> personsByName = persons.GroupBy(p => p.Name)
            .ToDictionary(p => p.Key, p => p.Average(p => p.Age));

        foreach (var person in personsByName)
        {
            Console.WriteLine("Имя: " + person.Key + ", Средний возраст: " + person.Value);
        }

        Console.WriteLine("Имена людей, возраст которых от 20 до 45 лет: " +
            string.Join(", ", persons.Where(p => p.Age >= 20 && p.Age <= 45).OrderByDescending(p => p.Age)));
    }
}