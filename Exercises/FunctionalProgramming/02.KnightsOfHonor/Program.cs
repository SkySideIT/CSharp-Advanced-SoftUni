namespace _02.KnightsOfHonor;

internal class Program
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        ForEachPlus(names, w => Console.WriteLine($"Sir {w}"));
    }

    static void ForEachPlus(string[] array, Action<string> action)
    {
        foreach (string el in array)
        {
            action(el);
        }
    }
}
