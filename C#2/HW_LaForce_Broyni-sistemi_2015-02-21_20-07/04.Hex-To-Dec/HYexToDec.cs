using System;

class AllocateArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 4. Hexadecimal to decimal
Write a program to convert hexadecimal numbers to their decimal 
representation.
============================================================================
Solution:");
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

        Console.WriteLine();
    }
}
