namespace _04.EvenTimes;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<int, int> countTimes = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (!countTimes.ContainsKey(number))
            {
                countTimes[number] = 0;
            }

            countTimes[number]++;
        }

        foreach (int number in countTimes.Keys)
        {
            if (countTimes[number] % 2 != 0)
            {
                continue;
            }

            Console.WriteLine(number);
        }
    }
}
