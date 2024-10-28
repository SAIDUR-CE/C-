
public class Person
{
    public string Name;
    public int Age;
    public string City;

    // Constructor with no parameters
    public Person()
    {
        Name = "Unknown";
        Age = 0;
        City = "Unknown";
    }

    // Constructor with one parameter
    public Person(string name)
    {
        Name = name;
        Age = 0;
        City = "Unknown";
    }

    // Constructor with two parameters
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        City = "Unknown";
    }

    // Constructor with three parameters
    public Person(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, City: {City}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using different constructors to create instances
        Person person1 = new Person();
        person1.DisplayInfo();  // Outputs: Name: Unknown, Age: 0, City: Unknown

        Person person2 = new Person("Alice");
        person2.DisplayInfo();  // Outputs: Name: Alice, Age: 0, City: Unknown

        Person person3 = new Person("Bob", 25);
        person3.DisplayInfo();  // Outputs: Name: Bob, Age: 25, City: Unknown

        Person person4 = new Person("Charlie", 30, "New York");
        person4.DisplayInfo();  // Outputs: Name: Charlie, Age: 30, City: New York
    }
}
