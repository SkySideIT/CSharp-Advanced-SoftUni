namespace _07.PredicateForNames;

internal class Program
{
    static void Main(string[] args)
    {
        int nameLength = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Filter(names, x => x.Length <= nameLength, x => Console.WriteLine(x));
    }

    static void Filter(string[] array, Predicate<string> condition, Action<string> action)
    {
        foreach (var el in array)
        {
            if (condition(el))
            {
                action(el);
            }
        }
    }
}
