using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

class BinaryFloat
{
    static void Main()
    {
        Console.WriteLine(@"Problem 9.* Binary floating-point
Write a program that shows the internal binary representation of given 
32-bit signed floating-point number in IEEE 754 format (the C# type float)
Example:
number	sign	exponent	mantissa
-27,25	1	10000011	10110100000000000000000
============================================================================
Solution:");

        Console.Write("Enter a with dot as decimal separator: ");
        float number = float.Parse(Console.ReadLine());

        int sign = number < 0 ? 1 : 0;
        number = Math.Abs(number);

        string binary = FloatNumberToBinary(number);

        if ((int)number == 0 || (int)number == 1) binary = "0" + binary;

        Console.WriteLine("Sign: {0} {1}", sign, sign == 1 ? "(minus)" : "(plus)");
        Console.WriteLine("Exponent: {0}", GetExponent(binary));
        Console.WriteLine("Mantissa: {0}\n", GetMantissa(binary));
    }

    static string FloatNumberToBinary(float number)
    {
        int dec = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);
        return Convert.ToString(dec, 2);
    }

    static string GetExponent(string binary)
    {
        return binary.Substring(0, 8);
    }

    static string GetMantissa(string binary)
    {
        return binary.Substring(8);
    }
}