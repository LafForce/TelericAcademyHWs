using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem 3. Line numbers
Write a program that reads a text file and inserts line numbers in front 
of each of its lines.
The result should be written to another text file.
============================================================================
Solution:");
        const string fileOnePath = "../../TextFile1.txt";
        const string fileResultPath = "../../result.txt";

        InsertLinesToResultFile(fileOnePath, fileResultPath);
        Console.WriteLine("The resulting text file is in the projects folder!");

    }

    static void InsertLinesToResultFile(string pathText, string pathResult)
    {
        int lineCount = 1;

        using (StreamWriter result = new StreamWriter(pathResult))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream) result.WriteLine("Line {0}: {1}", lineCount++, reader.ReadLine());
            }
        }
    }
}