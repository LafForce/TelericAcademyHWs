<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;
class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Matrix of Numbers
*Write a program that reads from the console a positive integer number 
`n` (1 = n = 20) and prints a matrix like in the examples below. Use two 
nested loops.
_Examples:_
	n = 2	matrix		n = 3	matrix		n = 4	matrix
                1 2                     1 2 3                   1 2 3 4 
                2 3                     2 3 4                   2 3 4 5 
                                        3 4 5                   3 4 5 6
                                                                4 5 6 7
-------------------------------------------------------------------------------
Solution:

");
        try
        {
            Console.WriteLine("Enter the integer n, please");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("n = {0}", n);
            Console.WriteLine();

            if (1 <= n && n <= 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < n +i; j++)
                    {
                        Console.Write("{0,2} ", j);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Otside of predefined conditions!");
            }
        }
        catch
        {
            Console.WriteLine("Insert integers, please");
        }
    }
}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;
class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Matrix of Numbers
*Write a program that reads from the console a positive integer number 
`n` (1 = n = 20) and prints a matrix like in the examples below. Use two 
nested loops.
_Examples:_
	n = 2	matrix		n = 3	matrix		n = 4	matrix
                1 2                     1 2 3                   1 2 3 4 
                2 3                     2 3 4                   2 3 4 5 
                                        3 4 5                   3 4 5 6
                                                                4 5 6 7
-------------------------------------------------------------------------------
Solution:

");
        try
        {
            Console.WriteLine("Enter the integer n, please");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("n = {0}", n);
            Console.WriteLine();

            if (1 <= n && n <= 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < n +i; j++)
                    {
                        Console.Write("{0,2} ", j);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Otside of predefined conditions!");
            }
        }
        catch
        {
            Console.WriteLine("Insert integers, please");
        }
    }
}>>>>>>> .r6
