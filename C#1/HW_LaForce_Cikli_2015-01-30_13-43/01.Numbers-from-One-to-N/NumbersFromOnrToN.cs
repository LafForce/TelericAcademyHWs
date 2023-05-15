
﻿using System; 

class NumbersFromOnrToN
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Numbers from 1 to N
*	Write a program that enters from the console a positive integer `n` and
prints all the numbers from `1` to `n`, on a single line, separated by a
space.
_Examples:_
| n            | output    | 
|--------------|-----------|
| 3            | 1 2 3     | 
| 5            | 1 2 3 4 5 
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
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
        catch
        {
            Console.WriteLine("Insert a positive integer, please");
            goto whereBadBoyzGo;
        }
    }
    
}

