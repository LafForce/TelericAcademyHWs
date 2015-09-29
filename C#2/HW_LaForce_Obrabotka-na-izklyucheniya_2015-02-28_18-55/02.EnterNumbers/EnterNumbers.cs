using System;

class EnterNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem 2. Enter numbers
Write a method ReadNumber(int start, int end) that enters an integer 
number in a given range [start…end].If an invalid number or non-number text
is entered, the method should throw an exception.Using this method write a 
program that enters 10 numbers: a1, a2, … a10, 
such that 1 < a1 < … < a10 < 100
============================================================================
Solution:");
        int start = 1;
        int end = 100;
        Console.WriteLine("Enter numbers between {0} and {1} such that 1 < a1 < … < a10 < 100", start, end);
        Console.WriteLine();
        int lowerBoundary = start; 
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Entry number {0} of 10:", i +1);
            lowerBoundary = ReadNumber(lowerBoundary, end);
            Console.WriteLine();
        }
        
    }
    static int ReadNumber(int start, int end)
    {
        try
        {
            Console.WriteLine("Enter number between {0} and {1}", start, end);
            int number = int.Parse(Console.ReadLine());
            if (number > end || number < start)
            {
                throw new ArgumentOutOfRangeException("Argument is out of the given range!");
            }
            return number;
        }
        catch (FormatException)
        {
            throw new FormatException("Format exeption!");
        }
    }
}