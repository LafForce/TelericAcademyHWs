using System;

class AllocateArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 3. Day of week
Write a program that prints to the console which day of the week is today.
Use System.DateTime.
============================================================================
Solution:");

        DateTime now = DateTime.Now;

        Console.WriteLine("Today is {0}!", now.DayOfWeek);
        Console.WriteLine();
    }
}
