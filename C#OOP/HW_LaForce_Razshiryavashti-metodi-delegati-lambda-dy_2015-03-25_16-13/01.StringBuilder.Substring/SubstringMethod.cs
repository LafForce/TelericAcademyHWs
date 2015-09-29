using System;
using System.Text;


public static class SubstringMethod
{
    public static StringBuilder Substring(this StringBuilder str, int index, int length)
    {
        StringBuilder result = new StringBuilder();

        if (index < 0 || index >= str.Length)
        {
            throw new IndexOutOfRangeException("The start index is out of range!");
        }
        else
        {
            if (length + index > str.Length)
                length = str.Length - index;
            for (int i = 0; i < length; i++)
            {
                result.Append(str[index + i]);
            }
            return result;
        }
    }

    static void Main()
    {
        Console.WriteLine(@"Problem 1. StringBuilder.Substring
Implement an extension method Substring(int index, int length) for the class 
StringBuilder that returns new StringBuilder and has the same functionality as 
Substring in the class String.
================================================================================
Solution:
");
        int index = 4;
        int length = 10;
        StringBuilder test = new StringBuilder("0123456789");
        Console.WriteLine("The StringBuilder \"test\" is \"{3}\" \nSubsting is called with the params: \nstart index {1}, \nlength : {2}\n\nThe result is {0}!"
            , test.Substring(index, length), index, length, test);
        Console.WriteLine();
    }
}
