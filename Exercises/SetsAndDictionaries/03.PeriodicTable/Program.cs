/*
4
Ce O
Mo O Ce
Ee
Mo
 
*/

namespace _03.PeriodicTable;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            foreach (string el in input)
            {
                set.Add(el);
            }
        }

        Console.WriteLine(string.Join(" ", set.OrderBy(x => x)));
    }
}
