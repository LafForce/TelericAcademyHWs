<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;

class minMaxAverage
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Min, Max, Sum and Average of N Numbers
*	Write a program that reads from the console a sequence of `n` integer
numbers and returns the minimal, the maximal number, the sum and the 
average of all numbers (displayed with 2 digits after the decimal point).
*	The input starts by the number `n` (alone in a line) followed by `n` 
lines, each holding an integer number.
*	The output is like in the examples below.
_Example 1:_
| input | output     |
|-------|------------|
| 3     | min = 1    |
| 2     | max = 5    |
| 5     | sum = 8    |
| 1     | avg = 2.67 |
_Example 2:_
| input | output     |
|-------|------------|
| 2     | min = -1   |
| -1    | max = 4    |
| 4     | sum = 3    |
|       | avg = 1.50 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Enter number of integers n, please");
        whereBadBoyzGo:
        try
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Now the {0} numbers, please:", n);

            for (int i = 1; i <= n; i++)
            {
            whereBaderBoyzGo:
                try
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num <= min)
                    {
                        min = num;
                    }
                    if (num >= max)
                    {
                        max = num;
                    }
                    sum += num;
                }
                catch
                {
                    Console.WriteLine("Probably not a number, please enter another {0} numbers!", n);
                    goto whereBaderBoyzGo;
                }
            }
            Console.WriteLine();
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}"
                   , min, max, sum, (float)sum / n);
        }
        catch
        {
            Console.WriteLine("Insert a positive number of numbers, please");
            goto whereBadBoyzGo;
        }
    }

}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;

class minMaxAverage
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Min, Max, Sum and Average of N Numbers
*	Write a program that reads from the console a sequence of `n` integer
numbers and returns the minimal, the maximal number, the sum and the 
average of all numbers (displayed with 2 digits after the decimal point).
*	The input starts by the number `n` (alone in a line) followed by `n` 
lines, each holding an integer number.
*	The output is like in the examples below.
_Example 1:_
| input | output     |
|-------|------------|
| 3     | min = 1    |
| 2     | max = 5    |
| 5     | sum = 8    |
| 1     | avg = 2.67 |
_Example 2:_
| input | output     |
|-------|------------|
| 2     | min = -1   |
| -1    | max = 4    |
| 4     | sum = 3    |
|       | avg = 1.50 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Enter number of integers n, please");
        whereBadBoyzGo:
        try
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Now the {0} numbers, please:", n);

            for (int i = 1; i <= n; i++)
            {
            whereBaderBoyzGo:
                try
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num <= min)
                    {
                        min = num;
                    }
                    if (num >= max)
                    {
                        max = num;
                    }
                    sum += num;
                }
                catch
                {
                    Console.WriteLine("Probably not a number, please enter another {0} numbers!", n);
                    goto whereBaderBoyzGo;
                }
            }
            Console.WriteLine();
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}"
                   , min, max, sum, (float)sum / n);
        }
        catch
        {
            Console.WriteLine("Insert a positive number of numbers, please");
            goto whereBadBoyzGo;
        }
    }

}>>>>>>> .r6
