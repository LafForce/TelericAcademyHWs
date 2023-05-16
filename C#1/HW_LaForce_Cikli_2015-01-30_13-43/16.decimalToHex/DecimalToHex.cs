using System;
using System.Globalization;
using System.Text;
using System.Threading;


    class DecimalToHex
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem:
Decimal to Hexadecimal Number
*Using loops write a program that converts an integer number to its
hexadecimal representation.
*The input is entered as long. The output should be a variable of type 
string.
*Do not use the built-in .NET functionality.
_Examples:_
| decimal      | hexadecimal |
|--------------|-------------|
| 254          | FE          |
| 6883         | 1AE3        |
| 338583669684 | 4ED528CBB4  |
-------------------------------------------------------------------------------
Solution:

");

            
            Console.Write("Enter a number in Decimal Format num = ");
            long input = long.Parse(Console.ReadLine());

            var ouputStr = new StringBuilder();

            while (input > 0)
            {
                var rm = input % 16;
                input /= 16;
                ouputStr.Insert(0,((int)rm).ToString("X"));
            }

            Console.WriteLine("hexadecimal result: is {0}"
                , ouputStr);
        }
    }
