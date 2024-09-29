namespace LambdaExspression;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name}";
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

        Person person = (Person)obj;

        return Name == person.Name && Age == person.Age;
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int hash = 1;

        hash = prime * hash + Name.GetHashCode();
        hash = prime * hash + Age.GetHashCode();

        return hash;
    }
}