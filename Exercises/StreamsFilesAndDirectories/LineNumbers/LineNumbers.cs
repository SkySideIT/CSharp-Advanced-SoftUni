namespace LineNumbers;

using System;
using System.IO;
using System.Linq;

public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";
        string outputFilePath = @"..\..\..\output.txt";

        ProcessLines(inputFilePath, outputFilePath);
    }

    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        string[] lines = File.ReadAllLines(inputFilePath);

        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = ProcessLine(i + 1, lines[i]);
        }

        File.WriteAllLines(outputFilePath, lines);
    }

    static string ProcessLine(int position, string line)
    {
        int lettersCount = 0, punctuationCount = 0;

        foreach (char ch in line)
        {
            if (char.IsLetter(ch))
            {
                lettersCount++;
            }
            else if (char.IsPunctuation(ch))
            {
                punctuationCount++;
            }
        }

        return $"Line {position}: {line} ({lettersCount})({punctuationCount})";
    }
}
