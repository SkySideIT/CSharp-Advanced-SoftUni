namespace _08.ListOfPredicates;

internal class Program
{
    static void Main(string[] args)
    {
        int end = int.Parse(Console.ReadLine());
        int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Func<int, bool>[] condition = new Func<int, bool>[dividers.Length];
        for (int i = 0; i < dividers.Length; i++)
        {
            int pos = i;
            condition[pos] = x => x % dividers[pos] == 0;
        }

        List<int> result = Filter(1, end, condition);
        Console.WriteLine(string.Join(" ", result));
    }

    static List<int> Filter(int start, int end, Func<int, bool>[] conditions)
    {
        List<int> result = new List<int>();

        for (int i = start; i <= end; i++)
        {
            bool isMatch = true;
            for (int j = 0; isMatch && j < conditions.Length; j++)
            {
                isMatch = conditions[j](i);
            }

            if (isMatch)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
