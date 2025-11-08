namespace _02.SetsOfElements;

internal class Program
{
    static void Main(string[] args)
    {
        int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = parameters[0];
        int m = parameters[1];

        HashSet<int> first = new HashSet<int>();
        HashSet<int> second = new HashSet<int>();
        HashSet<int> equalElements = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            first.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < m; i++)
        {
            second.Add(int.Parse(Console.ReadLine()));
        }

        foreach (int el in first)
        {
            if (second.Contains(el))
            {
                equalElements.Add(el);
            }
        }

        Console.WriteLine(string.Join(" ", equalElements));
    }
}
