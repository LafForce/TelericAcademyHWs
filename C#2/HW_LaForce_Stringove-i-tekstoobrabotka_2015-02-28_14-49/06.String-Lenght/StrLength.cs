using System;

class StrLength
{
    static void Main()
    {
        Console.WriteLine(@"Problem 6. String length
Write a program that reads from the console a string of maximum 20 
characters. If the length of the string is less than 20, the rest of the 
characters should be filled with *.
Print the result string into the console.
============================================================================
Solution:
");
        Console.WriteLine("Enter 20 char max string, please.");
        string string20 = Console.ReadLine();

        if (string20.Length < 20)
        {
            for (int i = string20.Length; i < 20; i++ )
            {
                string20 += "*";
            }
        }

        Console.WriteLine("Result: {0}!", string20);
    }
}
