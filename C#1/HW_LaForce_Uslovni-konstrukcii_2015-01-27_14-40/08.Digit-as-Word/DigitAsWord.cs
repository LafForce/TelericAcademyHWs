<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;


class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Digit as Word
*Write a program that asks for a digit (0-9), and depending on the input, 
shows the digit as a word (in English).
	*Print `“not a digit”` in case of invalid input.
	*Use a switch statement.
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


        Console.Write("Enter a digit in the range [0..9]: ");

        try
        {
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("not a digit");
                    break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("You have probably imputed an non-integral number type");
        }
    }
}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;


class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Digit as Word
*Write a program that asks for a digit (0-9), and depending on the input, 
shows the digit as a word (in English).
	*Print `“not a digit”` in case of invalid input.
	*Use a switch statement.
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


        Console.Write("Enter a digit in the range [0..9]: ");

        try
        {
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("not a digit");
                    break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("You have probably imputed an non-integral number type");
        }
    }
}>>>>>>> .r6
