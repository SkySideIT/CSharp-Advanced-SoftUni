namespace DirectoryTraversal;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class DirectoryTraversal
{
    static void Main()
    {
        string path = Console.ReadLine();
        string reportFileName = @"\report.txt";

        string reportContent = TraverseDirectory(path);
        Console.WriteLine(reportContent);

        WriteReportToDesktop(reportContent, reportFileName);
    }

    public static string TraverseDirectory(string inputFolderPath)
    {
        StringBuilder result = new StringBuilder();

        // extention -> file
        Dictionary<string, List<FileInfo>> filesByExtention = new Dictionary<string, List<FileInfo>>();

        foreach (string file in Directory.GetFiles(inputFolderPath))
        {
            FileInfo fileInfo = new FileInfo(file);

            if (!filesByExtention.ContainsKey(fileInfo.Extension))
            {
                filesByExtention[fileInfo.Extension] = new List<FileInfo>();
            }

            filesByExtention[fileInfo.Extension].Add(fileInfo);
        }

        foreach(var (extention, fileInfos) in filesByExtention.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            result.AppendLine(extention);
            foreach (FileInfo info in fileInfos.OrderBy(x => x.Length))
            {
                result.AppendLine($"--{info.Name} - {info.Length / 1024m}kb");
            }
        }

        return result.ToString();
    }

    public static void WriteReportToDesktop(string textContent, string reportFileName)
    {
        string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string pathToOutput = pathToDesktop + reportFileName;
        File.WriteAllText(pathToDesktop, textContent);
    }
}
