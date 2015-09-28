using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Quadratic Equation
*Write a program that reads the coefficients `a`, `b` and `c` of a quadratic 
equation ax<sup>2</sup> + bx + c = 0 and solves it (prints its real roots).
_Examples:_
|   a  |  b  |  c  |     roots     |
|:----:|:---:|:---:|---------------|
| 2    | 5   | -3  | x1=-3; x2=0.5 |
| -1   | 3   | 0   | x1=3; x2=0    |
| -0.5 | 4   | -8  | x1=x2=4       |
| 5    | 2   | 8   | no real roots |

-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert coefficients's a value, please.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert coefficients's b value, please.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert coefficients's c value, please.");
        double c = double.Parse(Console.ReadLine());
        double discriminant = ((b * b) - (4 * a * c));
        if (discriminant == 0)
        {
            double x1 = (-b) / (2 * a);
            Console.WriteLine("The roots are: x1 = x2 = {0}"
               , x1);
        }
        else if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("The roots are: x1 = {0} and x2 = {1}"
                , x2, x1);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }

    public static int discriminant { get; set; }
}