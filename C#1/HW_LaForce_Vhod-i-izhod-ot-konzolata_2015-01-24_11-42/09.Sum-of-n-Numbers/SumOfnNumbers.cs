<<<<<<< .mine
﻿using System;


class SumOfnNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Sum of n Numbers
*Write a program that enters a number `n` and after that enters more `n` 
numbers and calculates and prints their `sum`.
_Note: You may need to use a for-loop._
_Examples:_
| numbers | sum |
|---------|-----|
| 3       | 90  |
| 20      |     |
| 60      |     |
| 10      |     |
| 5       | 6.5 |
| 2       |     |
| -1      |     |
| -0.5    |     |
| 4       |     |
| 2       |     |
| 1       | 1   |
| 1       |     |

-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert number of numbers to be added, please.");
        int numN = int.Parse(Console.ReadLine());

        Console.WriteLine();
        double sumN = 0;

        for (int i = 1; i <= numN; i++)
        {
            double numberN = double.Parse(Console.ReadLine());
            sumN += numberN;
        }

        Console.WriteLine();
        Console.WriteLine(sumN);
    }
}||||||| .r0
=======
﻿using System;


class SumOfnNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Sum of n Numbers
*Write a program that enters a number `n` and after that enters more `n` 
numbers and calculates and prints their `sum`.
_Note: You may need to use a for-loop._
_Examples:_
| numbers | sum |
|---------|-----|
| 3       | 90  |
| 20      |     |
| 60      |     |
| 10      |     |
| 5       | 6.5 |
| 2       |     |
| -1      |     |
| -0.5    |     |
| 4       |     |
| 2       |     |
| 1       | 1   |
| 1       |     |

-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert number of numbers to be added, please.");
        int numN = int.Parse(Console.ReadLine());

        Console.WriteLine();
        double sumN = 0;

        for (int i = 1; i <= numN; i++)
        {
            double numberN = double.Parse(Console.ReadLine());
            sumN += numberN;
        }

        Console.WriteLine();
        Console.WriteLine(sumN);
    }
}>>>>>>> .r6
