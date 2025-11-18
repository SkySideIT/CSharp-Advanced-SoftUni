namespace _03.CustomMinFunction;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int min = Aggregate(numbers, (num, agg) => num < agg ? num : agg, int.MaxValue);
        Console.WriteLine(min);
    }

    static int Aggregate(int[] array, Func<int, int, int> func, int initial)
    {
        int aggregate = initial;
        foreach (int num in array)
        {
            aggregate = func(num, aggregate);
        }

        return aggregate;
    }
}
