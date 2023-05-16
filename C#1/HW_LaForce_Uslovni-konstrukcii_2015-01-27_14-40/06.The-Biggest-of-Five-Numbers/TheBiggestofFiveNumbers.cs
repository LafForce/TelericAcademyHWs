using System;
using System.Globalization;
using System.Threading;


class TheBiggestofFiveNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
 The Biggest of Five Numbers
*Write a program that finds the biggest of five numbers by using only five if 
statements.
_Examples:_
| a    | b    | c    |  d |   e  | biggest |
|------|------|------|:--:|:----:|---------|
| 5    | 2    | 2    | 4  | 1    | 5       |
| -2   | -22  | 1    | 0  | 0    | 1       |
| -2   | 4    | 3    | 2  | 0    | 4       |
| 0    | -2.5 | 0    | 5  | 5    | 5       |
| -3   | -0.5 | -1.1 | -2 | -0.1 | -0.1    |
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
            Console.WriteLine("Insert number's d value, please.");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert number's e value, please.");
            double e = double.Parse(Console.ReadLine());

            //for your convinince: ready imput for case 5 of the givven:
            //double a = -3;
            //double b = -0.5;
            //double c = -1.1;
            //double d = -2;
            //double e = -0.1;

            //and case 3 too:
            //double a = -2;
            //double b = 4;
            //double c = 3;
            //double d = 2;
            //double e = 0;
            
            string line = new string('=', 39);
            Console.WriteLine("You have entered the following numbers: \na= {0}, b= {1}, c= {2}, b= {3}, c= {4}", a, b, c, d, e);
            Console.WriteLine(line);
            
            if ((((a > b) && (b > c)) && (c > d)) && (d > e))
            {
                Console.WriteLine("The number {0} is the biggest of the five!", a);
            }
            else if ((((a < b) && (b > c)) && (c > d)) && (d > e))
            {
                Console.WriteLine("The number {0} is the biggest of the five!", b);
            }
            else if ((((a < b) && (b < c)) && (c > d)) && (d > e))
            {
                Console.WriteLine("The number {0} is the biggest of the five!", c);
            }
            else if ((((a < b) && (b > c)) && (c < d)) && (d > e))
            {
                Console.WriteLine("The number {0} is the biggest of the five!", d);
            }
            else
            {
                Console.WriteLine("The number {0} is the biggest of the five!", e);
            }
        }
        catch (Exception)
        {
            Console.WriteLine(@"You have probably not inserted a number");
        }
    }
}
