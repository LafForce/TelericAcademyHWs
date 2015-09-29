<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;


class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Numbers from 1 to n
*Write a program that reads an integer number `n` from the console and prints
all the numbers in the interval `[1..n]`, each on a single line.
_Note: You may need to use a for-loop._
_Examples:_
| input | output |
|-------|--------|
| 3     | 1      |
|       | 2      |
|       | 3      |
| 5     | 1      |
|       | 2      |
|       | 3      |
|       | 4      |
|       | 5      |
| 1     | 1      |
-------------------------------------------------------------------------------
Solution:

");

        Console.WriteLine("Insert number of numbers to be displayed, please.");
        int numN = int.Parse(Console.ReadLine());
        
        Console.WriteLine();

        for (int i = 1; i <= numN; i++ )
        {
            Console.WriteLine(i);
        }
    }
}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;


class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Numbers from 1 to n
*Write a program that reads an integer number `n` from the console and prints
all the numbers in the interval `[1..n]`, each on a single line.
_Note: You may need to use a for-loop._
_Examples:_
| input | output |
|-------|--------|
| 3     | 1      |
|       | 2      |
|       | 3      |
| 5     | 1      |
|       | 2      |
|       | 3      |
|       | 4      |
|       | 5      |
| 1     | 1      |
-------------------------------------------------------------------------------
Solution:

");

        Console.WriteLine("Insert number of numbers to be displayed, please.");
        int numN = int.Parse(Console.ReadLine());
        
        Console.WriteLine();

        for (int i = 1; i <= numN; i++ )
        {
            Console.WriteLine(i);
        }
    }
}>>>>>>> .r6
