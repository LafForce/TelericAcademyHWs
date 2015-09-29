using System;
using System.Globalization;
using System.Threading;

    class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Trailing Zeroes in N!
*Write a program that calculates with how many zeroes the factorial of a 
given number `n` has at its end.
*Your program should work well for very big numbers, e.g. `n=100000`.
_Examples:_
| n      | trailing zeroes of n! | explaination        |
|--------|-----------------------|---------------------|
| 10     | 2                     | 3628800             |
| 20     | 4                     | 2432902008176640000 |
| 100000 | 24999                 | think why           |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Enter number n, please!");
        int n = int.Parse(Console.ReadLine());

        int numberOf = 0;
        int divisor = 5;

        while ((n / divisor)>= 1)
        {
            numberOf += n / divisor;
            divisor *= 5;
        }
        Console.WriteLine("The factorial of {0} has {1} trailing zeroes!"
            , n, numberOf);
    }

}
