namespace _01.ActionPrint;

internal class Program
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        ForEach(names, w => Console.WriteLine(w));
    }

    static void ForEach(string[] array, Action<string> action)
    {
        foreach (string el in array)
        {
            action(el);
        }
    }
}
