using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        Console.WriteLine(@"Problem 1. Odd lines
Write a program that reads a text file and prints on the console its odd 
lines.
============================================================================
Solution:");
        const string path = @"..\..\TextFile1.txt";

        Console.WriteLine("Those are the odd lines of the file:");
        Console.WriteLine();

        using (StreamReader reader = new StreamReader(path))
        {
            int lineCount = 1;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (lineCount++ % 2 != 0) Console.WriteLine(line);
            }
        }
    }
}