namespace EvenLines;

using System;
using System.IO;
using System.Linq;
using System.Text;

public class EvenLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";

        Console.WriteLine(ProcessLines(inputFilePath));
    }

    public static string ProcessLines(string inputFilePath)
    {
        StringBuilder result = new StringBuilder();

        using (StreamReader inputReader = new StreamReader(inputFilePath))
        {
            int rowNumber = 0;
            while (!inputReader.EndOfStream)
            {
                string line = inputReader.ReadLine();
                if (rowNumber % 2 == 0)
                {
                    string[] words = SanitizeLine(line).Split();
                    Array.Reverse(words);

                    result.AppendLine(string.Join(" ", words));
                }
                rowNumber++;
            }
        }

        return result.ToString();
    }

    static string SanitizeLine(string line)
    {
        char[] chars = new[] { '-', '.', ',', '!', '?' };
        foreach (char ch in chars)
        {
            line = line.Replace(ch, '@');
        }

        return line;
    }
}
