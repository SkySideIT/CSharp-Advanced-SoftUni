namespace CopyDirectory;

using System;
using System.IO;

public class CopyDirectory
{
    static void Main()
    {
        string inputPath =  Console.ReadLine();
        string outputPath = Console.ReadLine();

        CopyAllFiles(inputPath, outputPath);
    }

    public static void CopyAllFiles(string inputPath, string outputPath)
    {
        if (Directory.Exists(outputPath))
        {
            Directory.Delete(outputPath, recursive: true);
        }

        Directory.CreateDirectory(outputPath);

        foreach (string pathToFile in Directory.GetFiles(inputPath))
        {
            string fileName = Path.GetFileName(pathToFile);
            string pathToDestination = Path.Combine(outputPath, fileName);

            File.Copy(pathToFile, pathToDestination);
        }
    }
}
