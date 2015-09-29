using System;
using System.Text;

class AllocateArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 3. Decimal to hexadecimal
Write a program to convert decimal numbers to their hexadecimal 
representation.
============================================================================
Solution:");
        Console.Write("Enter a number in Decimal Format num = ");
        long input = long.Parse(Console.ReadLine());

        var ouputStr = new StringBuilder();

        while (input > 0)
        {
            var rm = input % 16;
            input /= 16;
            ouputStr.Insert(0, ((int)rm).ToString("X"));
        }

        Console.WriteLine("hexadecimal result: is {0}"
            , ouputStr);

        Console.WriteLine();
    }
}
