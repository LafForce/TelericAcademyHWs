using System;
using System.IO;

class ConcTextFiles
{
    static void Main()
    {
        Console.WriteLine(@"Problem 2. Concatenate text files
Write a program that concatenates two text files into another text file.
============================================================================
Solution:");

        string fileOnePath = "../../TextFile1.txt";
        string fileTwoPath = "../../TextFile2.txt";
        string fileResultPath = "../../result.txt";

        ReadFileContent(fileOnePath, fileResultPath);
        ReadFileContent(fileTwoPath, fileResultPath);
        Console.WriteLine("The resulting text file is in the projects folder!");
    }
    static void ReadFileContent(string pathText, string pathResult)
    {
        using (StreamWriter result = new StreamWriter(pathResult, true))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream) result.WriteLine(reader.ReadLine());
            }
        }
    }
}