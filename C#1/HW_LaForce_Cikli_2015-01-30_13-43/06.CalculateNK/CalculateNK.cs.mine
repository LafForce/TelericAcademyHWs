using System;
using System.Globalization;
using System.Threading;
using System.Numerics;
class CalculateNK
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Calculate N! / K!
*	Write a program that calculates `n! / k!` for given `n` and `k` 
(1 < k < n < 100).
*	Use only one loop.
_Examples:_
| n           | k          | n! / k! |
|-------------|------------|---------|
| 5           | 2          | 60      |
| 6           | 5          | 6       |
| 8           | 3          | 6720    |
-------------------------------------------------------------------------------
Solution:

");
        try
        {
            Console.WriteLine("Enter the integer n, please");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the integer k, please");
            int k = int.Parse(Console.ReadLine());

            if (1 < k && k < n && n < 100)
            {
                BigInteger factorK = 1;
                BigInteger factorN = 1;

                for (int i = 1; i <= n; i++)
                {
                    if (i <= k)
                    {
                        factorK *= i;
                    }
                    factorN *= i;
                }
                Console.WriteLine();
                Console.WriteLine("Result: {0}", (factorN / factorK));
            }
            else
            {
                Console.WriteLine("Otside of predefined conditions!");
            }
        }
        catch
        {
            Console.WriteLine("Insert integers, please");
        }
    }

}