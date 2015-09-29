using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine(@"Problem 2. Reverse string
Write a program that reads a string, reverses it and prints the result at 
the console.
Example:
input	output
sample	elpmas
============================================================================
Solution:");
        Console.WriteLine("\nEnter string, please.");
        string leftToright = Console.ReadLine();
        StringBuilder rightToLeft =new  StringBuilder();

        for (int i = leftToright.Length - 1; i >= 0; i--)
        {
            rightToLeft.Append(leftToright[i]);
        }
        Console.WriteLine("\nResult:");
        Console.WriteLine(rightToLeft);
    }
}
