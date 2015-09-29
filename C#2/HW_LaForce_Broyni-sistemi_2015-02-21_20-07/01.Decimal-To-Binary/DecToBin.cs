using System;
using System.Text;

class DecToBin
{
    static void Main()
    {
        Console.WriteLine(@"Problem 1. Decimal to binary
Write a program to convert decimal numbers to their binary representation.
============================================================================
Solution:");
        Console.WriteLine("Insert decimal number, please.");
        long numberDecimal = long.Parse(Console.ReadLine());

        //for the first time I use stringbuilder but it is very confortable indeed
        var binary = new StringBuilder();

        long bit = 0;

        while (numberDecimal > 0)
        {
            bit = numberDecimal % 2;
            numberDecimal /= 2;
            binary.Insert(0, bit);
        }
        Console.WriteLine("The binary result is: {0}", binary);

        Console.WriteLine();
    }
}
