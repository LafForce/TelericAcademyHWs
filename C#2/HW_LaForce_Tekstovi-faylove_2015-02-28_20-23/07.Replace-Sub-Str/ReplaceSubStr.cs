using System;
using System.IO;

class ReplaceSubStr
{
    static void Main()
    {
        Console.WriteLine(@"Problem 7. Replace sub-string
Write a program that replaces all occurrences of the sub-string start with
the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
============================================================================
Solution:
");
        const string pathInput = "../../text.txt";
        const string pathOutput = "../../result.txt";

        ReplaceSubstrings(pathInput, pathOutput);
        Console.WriteLine("The resulting file can be found in the project's folder.");
    }

    static void ReplaceSubstrings(string pathText, string pathResult)
    {
        using (StreamWriter result = new StreamWriter(pathResult))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream)
                {
                    result.WriteLine(reader.ReadLine().Replace("Start", "finish"));
                }
            }
        }
    }
}