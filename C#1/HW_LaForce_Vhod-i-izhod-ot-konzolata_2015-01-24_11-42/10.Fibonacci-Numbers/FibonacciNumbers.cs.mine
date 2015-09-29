using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Fibonacci Numbers
*Write a program that reads a number `n` and prints on the console the first
`n` members of the Fibonacci sequence (at a single line, separated by comma 
and space - `, `) : `0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …`.
_Note: You may need to learn how to use loops._
_Examples:_
|   n  |        comments        |
|:----:|------------------------|
| 1    | 0                      |
| 3    | 0 1 1                  |
| 10   | 0 1 1 2 3 5 8 13 21 34 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert number of members of Fibonacci's sequence to be displayed, please.");
        int numF = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("0, 1, ");

        int memMinusTwo = 0;
        int memMinusOne = 1;
        int memCurrent = 1;

        for (int i = 1; i <= numF; i++)
        {
            memCurrent = memMinusOne + memMinusTwo;
            Console.Write(memCurrent + ", ");
            memMinusTwo = memMinusOne;
            memMinusOne = memCurrent;
        }
        Console.WriteLine();
    }
}