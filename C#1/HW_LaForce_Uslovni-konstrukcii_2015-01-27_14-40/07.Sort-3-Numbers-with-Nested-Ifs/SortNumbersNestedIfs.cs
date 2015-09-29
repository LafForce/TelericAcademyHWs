<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;


class SortNumbersNestedIfs
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Sort 3 Numbers with Nested Ifs
*Write a program that enters 3 real numbers and prints them sorted in descending 
order.
	*Use nested `if` statements.
_Note: Don’t use arrays and the built-in sorting functionality._
_Examples:_

| a    | b    | c    |     result     |
|------|------|------|----------------|
| 5    | 1    | 2    | 5 2 1          |
| -2   | -2   | 1    | 1 -2 -2        |
| -2   | 4    | 3    | 4 3 -2         |
| 0    | -2.5 | 5    | 5 0 -2.5       |
| -1.1 | -0.5 | -0.1 | -0.1 -0.5 -1.1 |
| 10   | 20   | 30   | 30 20 10       |
| 1    | 1    | 1    | 1 1 1          |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        try
        {
            Console.WriteLine("Please note that the comma (,) is the legitimate decimal sign!");
            Console.WriteLine("Insert number's a value, please.");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert number's b value, please.");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert number's c value, please.");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("You have entered the following numbers: a= {0}, b= {1}, c= {2}", a, b, c);

            if (a >= b)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else if (c > b)
                {
                    if (c > a)
                    {
                        Console.WriteLine("{0} {1} {2}", c, a, b);
                    }
                    else if (a > c)
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                }
            }
            else // if a < b
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else if (a < c)
                {
                    if (b < c)
                    {
                        Console.WriteLine("{0} {1 } {2}", c, b, a);
                    }
                    else if (b > c)
                    {

                        Console.WriteLine("{0} {1} {2}", b, c, a);
                    }
                }
            }


        }
        catch (Exception)
        {
            Console.WriteLine(@"You have probably not imputed a number");
        }
    }
}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;


class SortNumbersNestedIfs
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Sort 3 Numbers with Nested Ifs
*Write a program that enters 3 real numbers and prints them sorted in descending 
order.
	*Use nested `if` statements.
_Note: Don’t use arrays and the built-in sorting functionality._
_Examples:_

| a    | b    | c    |     result     |
|------|------|------|----------------|
| 5    | 1    | 2    | 5 2 1          |
| -2   | -2   | 1    | 1 -2 -2        |
| -2   | 4    | 3    | 4 3 -2         |
| 0    | -2.5 | 5    | 5 0 -2.5       |
| -1.1 | -0.5 | -0.1 | -0.1 -0.5 -1.1 |
| 10   | 20   | 30   | 30 20 10       |
| 1    | 1    | 1    | 1 1 1          |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        try
        {
            Console.WriteLine("Please note that the comma (,) is the legitimate decimal sign!");
            Console.WriteLine("Insert number's a value, please.");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert number's b value, please.");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert number's c value, please.");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("You have entered the following numbers: a= {0}, b= {1}, c= {2}", a, b, c);

            if (a >= b)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else if (c > b)
                {
                    if (c > a)
                    {
                        Console.WriteLine("{0} {1} {2}", c, a, b);
                    }
                    else if (a > c)
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                }
            }
            else // if a < b
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else if (a < c)
                {
                    if (b < c)
                    {
                        Console.WriteLine("{0} {1 } {2}", c, b, a);
                    }
                    else if (b > c)
                    {

                        Console.WriteLine("{0} {1} {2}", b, c, a);
                    }
                }
            }


        }
        catch (Exception)
        {
            Console.WriteLine(@"You have probably not imputed a number");
        }
    }
}>>>>>>> .r6
