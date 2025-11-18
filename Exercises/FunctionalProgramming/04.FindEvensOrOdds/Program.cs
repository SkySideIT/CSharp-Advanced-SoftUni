namespace _04.Fin_EvensOrOdds;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Predicate<int>> predicatesByCommand = new Dictionary<string, Predicate<int>>
        {
            ["odd"] = num => num % 2 != 0,
            ["even"] = num => num % 2 == 0
        };

        int[] boundries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int start = boundries[0], end = boundries[1];
        string command = Console.ReadLine();

        Predicate<int> predicate;
        if (predicatesByCommand.ContainsKey(command))
        {
            predicate = predicatesByCommand[command];
        }
        else
        {
            predicate = _ => false;
        }

        List<int> result = Filter(start, end, predicate);
        Console.WriteLine(string.Join(" ", result));
    }

    static List<int> Filter(int start, int end, Predicate<int> predicate)
    {
        List<int> result = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (predicate(i))
            {
                result.Add(i);
            }
        }

        return result;
    }

}
