namespace _06.ReverseAndExclude;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int devider = int.Parse(Console.ReadLine());

        List<int> result = FilterInReverse(numbers, n => n % devider != 0);
        Console.WriteLine(string.Join(" ", result));
    }

    static List<int> FilterInReverse(int[] array, Predicate<int> condition)
    {
        List<int> result = new List<int>();

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (condition(array[i]))
            {
                result.Add(array[i]);
            }
        }

        return result;
    }
}
