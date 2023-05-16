using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Exchange If Greater
*Write an if-statement that takes two double variables a and b and exchanges
their values if the first one is greater than the second one. As a result
print the values a and b, separated by a space.
_Examples:_
| a    | b   | result  |
|------|-----|---------|
| 5    | 2   | 2 5     |
| 3    | 4   | 3 4     |
| 5.5  | 4.5 | 4.5 5.5 |
-------------------------------------------------------------------------------
Solution:

");
        //That's because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert number a's value, please.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number b's value, please.");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("| {0,-5}| {1,-5}| {2,-8}|", "a", "b", "reult");
        Console.Write("| {0,-5}| {1,5}|", a, b);
       
        
        if (a > b)
        {
            double c = b;
            b = a; 
            a = c;
        }

        Console.WriteLine(" {0,-8}|", a + " " + b);
    }
}