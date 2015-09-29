using System;

class ReverseNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem 7. Reverse number
Write a method that reverses the digits of given decimal number.
Example:
input	output
256	652		
============================================================================
Solution:");

        Reverse();
    }
    static void Reverse()
    {
        Console.WriteLine("Insert number whose digits you want reversed, please.");

        string num = Console.ReadLine();
        char[] numChars = num.ToCharArray();
        Array.Reverse(numChars);

        for (int i = 0; i < numChars.Length; i++)
        {
            Console.Write(numChars[i]);
        }
        Console.WriteLine();
    }
}
