using System;

class AllocateArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 2. Binary to decimal
Write a program to convert binary numbers to their decimal representation.
============================================================================
Solution:");

        Console.WriteLine("Insert binary number, please.");
        string redica = Console.ReadLine();

        char[] binary = redica.ToCharArray();

        long result = 0;

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                result += (long)Math.Pow(2, binary.Length - i - 1);
            }
        }
        Console.WriteLine("The Decimal result is: {0}", result);
        Console.WriteLine();
    }
}
