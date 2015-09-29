using System;

class AllocateArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 2. Random numbers
Write a program that generates and prints to the console 10 random values 
in the range [100, 200].
============================================================================
Solution:");
        Random peshoRandoma = new Random();

        for (int i = 0; i <= 9; i++)
        {
            Console.WriteLine("Random number {0,-2} is : {1}", i + 1, peshoRandoma.Next(100, 200));
        }

        Console.WriteLine();
    }
}
