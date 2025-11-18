namespace _11.TriFunction;

internal class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string result = First(names, x => NameIsSpecial(x, num));
        Console.WriteLine(result);
    }

    static string First(string[] array, Func<string, bool> condition)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (condition(array[i]))
            {
                return array[i];
            }
        }

        throw new InvalidOperationException("No elements match the given condition!");
    }

    static bool NameIsSpecial(string name, int n)
    {
        int sum = 0;
        for (int i = 0; i < name.Length; i++)
        {
            sum += name[i];
        }
        return sum >= n;
    }
}
