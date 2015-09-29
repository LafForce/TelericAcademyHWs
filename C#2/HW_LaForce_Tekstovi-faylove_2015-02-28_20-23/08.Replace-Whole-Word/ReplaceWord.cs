using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWord
{
    static void Main()
    {
        Console.WriteLine(@"Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words
(not strings).
============================================================================
Solution:
");
        const string pathInput = "../../text.txt";
        const string pathOutput = "../../result.txt";
       

        ReplaceAllWholeWords(pathInput, pathOutput);
    }

    static void ReplaceAllWholeWords(string pathText, string pathResult)
    {
        using (StreamWriter result = new StreamWriter(pathResult))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream)
                {
                    result.WriteLine(Regex.Replace(reader.ReadLine(), @"\bstart\b", "finish"));
                }
            }
        }
    }
}