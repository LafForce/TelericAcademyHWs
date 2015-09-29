<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Multiplication Sign
*Write a program that shows the sign (+, - or 0) of the product of three real 
numbers, without calculating it.
	*Use a sequence of `if` operators.
_Examples:_
| a    | b    | c    | result |
|------|------|------|:------:|
| 5    | 2    | 2    | +      |
| -2   | -2   | 1    | +      |
| -2   | 4    | 3    | -      |
| 0    | -2.5 | 4    | 0      |
| -1   | -0.5 | -5.1 | -      |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
       
        Console.WriteLine("Insert number's a value, please.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's b value, please.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's c value, please.");
        double c = double.Parse(Console.ReadLine());
        string result = "";

        if ((a == 0) | (b == 0) | (c == 0))
        {
            result = "0";
        }
        else if (a < 0 & (b > 0 & c > 0))
        {
            result = "-";
        }
        else if (b < 0 & (a > 0 & c > 0))
        {
            result = "-";
        }
        else if (c < 0 & (a > 0 & b > 0))
        {
            result = "-";
        }
        else if ((b < 0 & c < 0) & a > 0)
        {
            result = "+";
        }
         else if ((c < 0 & a < 0) & b > 0)
        {
            result = "+";
        }
        else if ((b < 0 & a < 0) & c > 0)
        {
            result = "+";
        }
        else if (a > 0 & b >0 & c > 0)
        {
            result = "+";
        }
        else
            result = "-";

        Console.WriteLine("| {0,-8}| | {1,-8}| {2,-8}| {3,-16}|", "a", "b", "c", "reult");
        Console.WriteLine("| {0,-8}| | {1,-8}| {2,-8}| {3,-16}|", a, b, c, result);

    }
}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Multiplication Sign
*Write a program that shows the sign (+, - or 0) of the product of three real 
numbers, without calculating it.
	*Use a sequence of `if` operators.
_Examples:_
| a    | b    | c    | result |
|------|------|------|:------:|
| 5    | 2    | 2    | +      |
| -2   | -2   | 1    | +      |
| -2   | 4    | 3    | -      |
| 0    | -2.5 | 4    | 0      |
| -1   | -0.5 | -5.1 | -      |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
       
        Console.WriteLine("Insert number's a value, please.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's b value, please.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's c value, please.");
        double c = double.Parse(Console.ReadLine());
        string result = "";

        if ((a == 0) | (b == 0) | (c == 0))
        {
            result = "0";
        }
        else if (a < 0 & (b > 0 & c > 0))
        {
            result = "-";
        }
        else if (b < 0 & (a > 0 & c > 0))
        {
            result = "-";
        }
        else if (c < 0 & (a > 0 & b > 0))
        {
            result = "-";
        }
        else if ((b < 0 & c < 0) & a > 0)
        {
            result = "+";
        }
         else if ((c < 0 & a < 0) & b > 0)
        {
            result = "+";
        }
        else if ((b < 0 & a < 0) & c > 0)
        {
            result = "+";
        }
        else if (a > 0 & b >0 & c > 0)
        {
            result = "+";
        }
        else
            result = "-";

        Console.WriteLine("| {0,-8}| | {1,-8}| {2,-8}| {3,-16}|", "a", "b", "c", "reult");
        Console.WriteLine("| {0,-8}| | {1,-8}| {2,-8}| {3,-16}|", a, b, c, result);

    }
}>>>>>>> .r6
