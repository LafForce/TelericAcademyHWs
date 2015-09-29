using System;

class AllocateArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 1. Allocate array
*Write a program that allocates array of `20` integers and initializes 
each element by its index multiplied by `5`.
*Print the obtained array on the console.
============================================================================
Solution:");

        int[] twentyInt = new int[20];

        for (int i = 0; i < 20; i++)
        {
            twentyInt[i] = 5 * i;
        }

        for (int i = 0; i < twentyInt.Length; i++)
        {
            Console.Write("{0}; ", twentyInt[i]);
        }
        Console.WriteLine();
    }
}

