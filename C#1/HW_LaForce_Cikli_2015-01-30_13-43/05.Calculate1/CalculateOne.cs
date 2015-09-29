<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;
class CalculateOne
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
*Write a program that, for a given two integer numbers `n` and `x`, 
calculates the sum `S = 1 + 1!/x + 2!/x^2 + … + n!/x^n`.
*Use only one loop. Print the result with `5` digits after the decimal 
point.
_Examples:_
| n           | x          | S       |
|-------------|------------|---------|
| 3           | 2          | 2.75000 |
| 4           | 3          | 2.07407 |
| 5           | -4         | 0.75781 |
-------------------------------------------------------------------------------
Solution:

");
        try
        {
            Console.WriteLine("Enter the integer n, please");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the integer x, please");
            int x = int.Parse(Console.ReadLine());
            
            double factor = 1.0;
            double xFactor = 1.0;
            double suma = 1.0;
            
            for (int i = 1; i <= n; i++)
            {
                factor *= i;
                xFactor *= x;
                suma += (factor / xFactor);
            }
            Console.WriteLine();
            Console.WriteLine("Result: {0:F5}", suma);
 
        }
        catch
        {
            Console.WriteLine("Insert integers, please");
        }
    }

}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;
class CalculateOne
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
*Write a program that, for a given two integer numbers `n` and `x`, 
calculates the sum `S = 1 + 1!/x + 2!/x^2 + … + n!/x^n`.
*Use only one loop. Print the result with `5` digits after the decimal 
point.
_Examples:_
| n           | x          | S       |
|-------------|------------|---------|
| 3           | 2          | 2.75000 |
| 4           | 3          | 2.07407 |
| 5           | -4         | 0.75781 |
-------------------------------------------------------------------------------
Solution:

");
        try
        {
            Console.WriteLine("Enter the integer n, please");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the integer x, please");
            int x = int.Parse(Console.ReadLine());
            
            double factor = 1.0;
            double xFactor = 1.0;
            double suma = 1.0;
            
            for (int i = 1; i <= n; i++)
            {
                factor *= i;
                xFactor *= x;
                suma += (factor / xFactor);
            }
            Console.WriteLine();
            Console.WriteLine("Result: {0:F5}", suma);
 
        }
        catch
        {
            Console.WriteLine("Insert integers, please");
        }
    }

}>>>>>>> .r6
