using System;
using System.Globalization;
using System.Threading;

class BinaryTodecimalnum
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem:
Binary to Decimal Number
*Using loops write a program that converts a binary integer number to its
decimal form.
*The input is entered as string. The output should be a variable of type long.
*Do not use the built-in .NET functionality.
_Examples:_
| binary                       | decimal   |
|------------------------------|-----------|
| 0                            | 0         |
| 11                           | 3         |
| 1010101010101011             | 43691     |
| 1110000110000101100101000000 | 236476736 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert binary number, please.");
        string redica = Console.ReadLine();

        char[] binary = redica.ToCharArray();

        long result = 0L;

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                result += (long)Math.Pow(2, binary.Length - i - 1);
            }
        }
        Console.WriteLine("The Decimal result is: {0}", result);
    }
}

