using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine(@"Problem 1. Square root
Write a program that reads an integer number and calculates and prints its 
square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
============================================================================
Solution:
");
        try
        {
            Console.WriteLine("Insert positive integer number, please.");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");

        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number.");
        }

        finally
        {
            Console.WriteLine("Good bye.");
    }
    }

}
