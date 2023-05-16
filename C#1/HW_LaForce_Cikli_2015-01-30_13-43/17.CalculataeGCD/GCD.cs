using System;
using System.Globalization;
using System.Threading;


    class GCD
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Calculate GCD
*Write a program that calculates the greatest common divisor (GCD) of given
two integers `a` and `b`.
*Use the Euclidean algorithm (find it in Internet).
_Examples:_
| a  | b   | GCD(a, b) |
|----|-----|-----------|
| 3  | 2   | 1         |
| 60 | 40  | 20        |
| 5  | -15 | 5         |
-------------------------------------------------------------------------------
Solution:

");
        try
        {
            Console.WriteLine("Enter the integer a, please");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the integer b, please");
            int b = int.Parse(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
           
                Console.WriteLine("The GCD of the numbers is: {0}"
                    , (a == 0) ? b : a);

        }
        catch
        {
            Console.WriteLine("Insert integers, please");
        }
    }

}
