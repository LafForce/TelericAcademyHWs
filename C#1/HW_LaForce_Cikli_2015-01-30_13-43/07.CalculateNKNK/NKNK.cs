<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;
using System.Numerics;
class NKNK
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Calculate N! / (K! * (N-K)!)
*In combinatorics, the number of ways to choose `k` different members out 
of a group of `n` different elements (also known as the number of 
combinations) is calculated by the following formula:
![formula]
(https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png)
For example, there are 2598960 ways to withdraw 5 cards out of a standard 
deck of 52 cards.
*Your task is to write a program that calculates `n! / (k! * (n-k)!)` for 
given `n` and `k` (1 < k < n < 100). Try to use only two loops.
_Examples:_
| n           | k | n! / (k! * (n-k)!) |
|-------------|---|--------------------|
| 3           | 2 | 3                  |
| 4           | 2 | 6                  |
| 10          | 6 | 210                |
| 52          | 5 | 2598960            |
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
                BigInteger factorNK = 1;
                for (int i = 1; i <= n; i++)
                {
                    if (i <= k)
                    {
                        factorK *= i;
                    }
                    if (i > k)
                    {
                        factorNK *= (i - k);
                    }
                    factorN *= i;
                }
                Console.WriteLine();
                Console.WriteLine("Result: {0}", (factorN / (factorK * factorNK)));
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

}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;
using System.Numerics;
class NKNK
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Calculate N! / (K! * (N-K)!)
*In combinatorics, the number of ways to choose `k` different members out 
of a group of `n` different elements (also known as the number of 
combinations) is calculated by the following formula:
![formula]
(https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png)
For example, there are 2598960 ways to withdraw 5 cards out of a standard 
deck of 52 cards.
*Your task is to write a program that calculates `n! / (k! * (n-k)!)` for 
given `n` and `k` (1 < k < n < 100). Try to use only two loops.
_Examples:_
| n           | k | n! / (k! * (n-k)!) |
|-------------|---|--------------------|
| 3           | 2 | 3                  |
| 4           | 2 | 6                  |
| 10          | 6 | 210                |
| 52          | 5 | 2598960            |
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
                BigInteger factorNK = 1;
                for (int i = 1; i <= n; i++)
                {
                    if (i <= k)
                    {
                        factorK *= i;
                    }
                    if (i > k)
                    {
                        factorNK *= (i - k);
                    }
                    factorN *= i;
                }
                Console.WriteLine();
                Console.WriteLine("Result: {0}", (factorN / (factorK * factorNK)));
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

}>>>>>>> .r6
