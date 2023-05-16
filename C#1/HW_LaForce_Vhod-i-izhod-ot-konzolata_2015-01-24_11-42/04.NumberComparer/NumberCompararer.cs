using System;
using System.Globalization;
using System.Threading;

class NumberCompararer
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Number Comparer
* Write a program that gets two numbers from the console and prints the greater of 
them.
* Try to implement this without if statements.
_Examples:_
|  a  |  b  | greater |
|:---:|:---:|:-------:|
| 5   | 6   | 6       |
| 10  | 5   | 10      |
| 0   | 0   | 0       |
| -5  | -2  | -2      |
| 1.5 | 1.6 | 1.6     |

-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert number's a value, please.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's b value, please.");
        double b = double.Parse(Console.ReadLine());


        Console.WriteLine("The bigger of the numbers a = {0} and b = {1} is:\nthe number {2} = {3}"
            , a, b, a > b ? "a" : "b", a > b ? a : b);

    }
}
 