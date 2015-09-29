using System;
using System.Globalization;
using System.Threading;

class RandomInRange
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
 Random Numbers in Given Range
*Write a program that enters `3` integers `n`, `min` and `max` (`min != max`)
and prints `n` random numbers in the range `[min...max]`.
_Examples:_
| n                 | min | max     |         random numbers        |
|-------------------|-----|---------|-------------------------------|
| 5                 | 0   | 1       | 1 0 0 1 1                     |
| 10                | 10  | 15      | 12 14 12 15 10 12 14 13 13 11 |
_Note: The above output is just an example. Due to randomness, your program 
most probably will produce different results._
-------------------------------------------------------------------------------
Solution:

");
        try
        {
            Console.WriteLine("Insert number of random nmbers \"n\" to be displayed, please");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert min value of the range, please");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert max value of the range, please");
            int max = int.Parse(Console.ReadLine());

            Random peshoRandoma = new Random();

            for (int i = 0; i < n; i++)
            {
                int numbRand = peshoRandoma.Next(min, max);
                Console.Write(numbRand + " ");
            }
        }
        catch
        {
            Console.WriteLine("Something is wrong :_), dude :=!");
        }

    }
}
