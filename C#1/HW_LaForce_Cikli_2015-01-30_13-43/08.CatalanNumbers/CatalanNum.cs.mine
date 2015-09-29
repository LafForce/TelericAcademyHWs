using System;
using System.Numerics;
class CatalanNum
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Catalan Numbers
*In combinatorics, the Catalan numbers are calculated by the following formula:
![catalan-formula]
(https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png)
*Write a program to calculate the `nth` Catalan number by given `n` 
(0 < n < 100). 
_Examples:_
| n           | Catalan(n) |
|-------------|------------|
| 0           | 1          |
| 5           | 42         |
| 10          | 16796      |
| 15          | 9694845    |
| 52          | 5 | 2598960            |
-------------------------------------------------------------------------------
Solution:

");
        try
        {
            Console.WriteLine("Enter the integer n, please");
            int n = int.Parse(Console.ReadLine());

            if (0 <= n && n <= 100)
            {
                BigInteger factorTwoN = 1;
                BigInteger factorN = 1;
                BigInteger factorNplus = 1;

                for (int i = 1; i <= 2 * n; i++)
                {
                    if (i <= n)
                    {
                    factorN *= i;
                    }
                    if (i <= n +1)
                    {
                        factorNplus *= i;
                    }
                    factorTwoN *= i;
                }
                Console.WriteLine();
                Console.WriteLine("Result: {0}", (factorTwoN / (factorNplus * factorN)));
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