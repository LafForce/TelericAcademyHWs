<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;


class BiggestThreeNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
 The Biggest of 3 Numbers
*Write a program that finds the biggest of three numbers.
_Examples:_
| a    | b    | c    | biggest |
|------|------|------|:-------:|
| 5    | 2    | 2    | 5       |
| -2   | -2   | 1    | 1       |
| -2   | 4    | 3    | 4       |
| 0    | -2.5 | 5    | 5       |
| -0.1 | -0.5 | -1.1 | -0.1    |
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

            if ((a > b) && (b > c))
            {
                Console.WriteLine("The number a = {0} is the biggest of the three!", a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("The number a = {0} is the biggest of the three!", b);
            }
            else
            {
                Console.WriteLine("The number a = {0} is the biggest of the three!", c);
            }

        }
        catch (Exception)
        {
            Console.WriteLine(@"You have probably not imputed a number");
        }
    }
}
||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;


class BiggestThreeNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
 The Biggest of 3 Numbers
*Write a program that finds the biggest of three numbers.
_Examples:_
| a    | b    | c    | biggest |
|------|------|------|:-------:|
| 5    | 2    | 2    | 5       |
| -2   | -2   | 1    | 1       |
| -2   | 4    | 3    | 4       |
| 0    | -2.5 | 5    | 5       |
| -0.1 | -0.5 | -1.1 | -0.1    |
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

            if ((a > b) && (b > c))
            {
                Console.WriteLine("The number a = {0} is the biggest of the three!", a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("The number a = {0} is the biggest of the three!", b);
            }
            else
            {
                Console.WriteLine("The number a = {0} is the biggest of the three!", c);
            }

        }
        catch (Exception)
        {
            Console.WriteLine(@"You have probably not imputed a number");
        }
    }
}
>>>>>>> .r6
