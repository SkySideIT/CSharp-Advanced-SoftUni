namespace _05.CountSymbols;

internal class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        Dictionary<char, int> charMap = new Dictionary<char, int>();

        foreach (char ch in text)
        {
            if (!charMap.ContainsKey(ch))
            {
                charMap[ch] = 0;
            }

            charMap[ch]++;
        }

        foreach (char ch in charMap.Keys.OrderBy(x => x))
        {
            Console.WriteLine($"{ch}: {charMap[ch]} time/s");
        }
    }
}
