using System;
using System.Text;

class UnicodeChar
{
    static void Main()
    {
        Console.WriteLine(@"Problem 10. Unicode characters
Write a program that converts a string to a sequence of C# Unicode character 
literals.
Use format strings.
Example:
input	output
Hi!	\u0048\u0069\u0021
============================================================================
Solution:");
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();

        Console.WriteLine(ParseToUnicode(text));
    }

    private static string ParseToUnicode(string text)
    {
        StringBuilder result = new StringBuilder();

        foreach (var letter in text)
        {
            result.Append(String.Format("\\u{0:X4}", (int)letter));
        }

        return result.ToString();
    }
}