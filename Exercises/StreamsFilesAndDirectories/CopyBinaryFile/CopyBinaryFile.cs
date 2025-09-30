namespace CopyBinaryFile;

using System;
using System.IO;

public class CopyBinaryFile
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\copyMe.png";
        string outputFilePath = @"..\..\..\copyMe-copy.png";

        CopyFile(inputFilePath, outputFilePath);
    }

    public static void CopyFile(string inputFilePath, string outputFilePath)
    {
        using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
        {
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];

                int readBytesCount;
                while ((readBytesCount = inputStream.Read(buffer)) != 0)
                {
                    outputStream.Write(buffer, 0, readBytesCount);
                }
            }
        }
    }
}
