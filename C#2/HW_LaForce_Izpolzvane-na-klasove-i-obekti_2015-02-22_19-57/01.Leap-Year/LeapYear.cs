using System;
using System.Globalization;
class LeapYear
{
    static void Main()
    {
        Console.WriteLine(@"Problem 1. Leap year
Write a program that reads a year from the console and checks whether it 
is a leap one.
Use System.DateTime.
============================================================================
Solution:");

        Console.WriteLine("Insert year in format \"yyyy\", please.");
        DateTime isLeap = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("The year {0} is {1}.", 
            isLeap.Year, DateTime.IsLeapYear(isLeap.Year) ? "a leap one" : "not a leap one");

        Console.WriteLine();
    }
}
