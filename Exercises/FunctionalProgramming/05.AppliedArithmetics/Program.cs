/*
1 2 3 4 5
add
add
print
end
 
 */


namespace _05.AppliedArithmetics;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Action<int[]>> actionByCommands = new Dictionary<string, Action<int[]>>
        {
            ["add"] = arr => Transform(arr, x => x + 1),
            ["multiply"] = arr => Transform(arr, x => x * 2),
            ["subtract"] = arr => Transform(arr, x => x - 1),
            ["print"] = arr => Console.WriteLine(string.Join(" ", arr))
        };

        int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            if (actionByCommands.ContainsKey(input))
            {
                actionByCommands[input](numbers);
            }
        }
    }

    static void Transform(int[] array, Func<int, int> transform)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = transform(array[i]);
        }
    }
}
