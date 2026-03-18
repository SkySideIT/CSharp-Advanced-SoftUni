namespace _02.CreatingConstructor;

public class StartUp
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Name = "Test";
        person1.Age = 30;

        Person person2 = new Person { Name = "Jose", Age = 24 };
    }
}
