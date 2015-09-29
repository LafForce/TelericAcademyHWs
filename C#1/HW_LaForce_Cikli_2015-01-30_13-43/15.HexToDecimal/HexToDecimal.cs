<<<<<<< .mine
﻿using System;
using System.Linq;
using System.Text;

class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Hexadecimal to Decimal Number
*Using loops write a program that converts a hexadecimal integer number to 
its decimal form.
*The input is entered as string. The output should be a variable of type long.
*Do not use the built-in .NET functionality.
_Examples:_
| hexadecimal       | decimal                      |
|-------------------|------------------------------|
| FE                | 254                          |
| 1AE3              | 6883                         |
| 4ED528CBB4        | 338583669684                 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert a hexadecimal number, please.");
        string numberHex = Console.ReadLine();

        long numberDec = 0;

        for (int i = numberHex.Length - 1; i >= 0; i--)
        {
            switch (numberHex[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    numberDec += (long.Parse(numberHex[i].ToString())) * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'A':
                    numberDec += 10 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'B':
                    numberDec += 11 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'C':
                    numberDec += 12 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'D':
                    numberDec += 13 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'E':
                    numberDec += 14 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'F':
                    numberDec += 15 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
            }
        }
        Console.WriteLine("The decimal result is: {0}", numberDec);
    }
}||||||| .r0
=======
﻿using System;
using System.Linq;
using System.Text;

class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Hexadecimal to Decimal Number
*Using loops write a program that converts a hexadecimal integer number to 
its decimal form.
*The input is entered as string. The output should be a variable of type long.
*Do not use the built-in .NET functionality.
_Examples:_
| hexadecimal       | decimal                      |
|-------------------|------------------------------|
| FE                | 254                          |
| 1AE3              | 6883                         |
| 4ED528CBB4        | 338583669684                 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert a hexadecimal number, please.");
        string numberHex = Console.ReadLine();

        long numberDec = 0;

        for (int i = numberHex.Length - 1; i >= 0; i--)
        {
            switch (numberHex[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    numberDec += (long.Parse(numberHex[i].ToString())) * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'A':
                    numberDec += 10 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'B':
                    numberDec += 11 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'C':
                    numberDec += 12 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'D':
                    numberDec += 13 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'E':
                    numberDec += 14 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'F':
                    numberDec += 15 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
            }
        }
        Console.WriteLine("The decimal result is: {0}", numberDec);
    }
}>>>>>>> .r6
