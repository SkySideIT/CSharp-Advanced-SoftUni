/*
4
Blue -> dress,jeans,hat
Gold -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
Blue dress

*/

using System.Text;

namespace _06.Wardrobe;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, int>> wardrobeMap = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            string color = input[0];
            string[] clothes = input[1].Split(",");

            if (!wardrobeMap.ContainsKey(color))
            {
                wardrobeMap[color] = new Dictionary<string, int>();
            }

            foreach (string cloth in clothes)
            {
                if (!wardrobeMap[color].ContainsKey(cloth))
                {
                    wardrobeMap[color][cloth] = 0;
                }

                wardrobeMap[color][cloth]++;
            }
        }

        string[] search = Console.ReadLine().Split();
        string searchedColor = search[0];
        string searchedCloth = search[1];
        StringBuilder output = new StringBuilder();

        foreach ((string color, var clothesByCount) in wardrobeMap)
        {
            Console.WriteLine($"{color} clothes:");
            foreach ((string cloth, int count) in clothesByCount)
            {
                output.Append($"* {cloth} - {count}");

                if (color == searchedColor && cloth == searchedCloth)
                {
                   output.Append(" (found!)");
                }

                Console.WriteLine(output.ToString());
                output.Clear();
            }
        }
    }
}
