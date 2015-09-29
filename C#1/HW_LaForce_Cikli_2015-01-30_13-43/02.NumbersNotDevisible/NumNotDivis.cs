<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;

class NumNotDivis

{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Numbers Not Divisible by 3 and 7
*	Write a program that enters from the console a positive integer `n` and
prints all the numbers from `1` to `n` not divisible by `3` and `7`, on a
single line, separated by a space.
_Examples:_
| n  | output       |
|----|--------------|
| 3  | 1 2          |
| 10 | 1 2 4 5 8 10 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("enter positive integer n, please");
        whereBadBoyzGo:
        try
        {

            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();
        }
        catch
        {
            Console.WriteLine("Insert a positive integer, please");
            goto whereBadBoyzGo;
        }
    }

}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;

class NumNotDivis

{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Numbers Not Divisible by 3 and 7
*	Write a program that enters from the console a positive integer `n` and
prints all the numbers from `1` to `n` not divisible by `3` and `7`, on a
single line, separated by a space.
_Examples:_
| n  | output       |
|----|--------------|
| 3  | 1 2          |
| 10 | 1 2 4 5 8 10 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("enter positive integer n, please");
        whereBadBoyzGo:
        try
        {

            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();
        }
        catch
        {
            Console.WriteLine("Insert a positive integer, please");
            goto whereBadBoyzGo;
        }
    }

}>>>>>>> .r6
