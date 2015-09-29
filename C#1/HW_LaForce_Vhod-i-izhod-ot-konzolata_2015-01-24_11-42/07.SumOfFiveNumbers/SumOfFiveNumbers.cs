<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Sum of 5 Numbers
*Write a program that enters 5 numbers (given in a single line, separated by 
a space), calculates and prints their sum.
_Examples:_
|      numbers      |  sum  |
|-------------------|-------|
| 1 2 3 4 5         | 15    |
| 10 10 10 10 10    | 50    |
| 1.5 3.14 8.2 -1 0 | 11.84 |

-------------------------------------------------------------------------------
Solution:

"); 
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert first number's, please.");
        double firstN = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number's, please.");
        double SecondN = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert third number's, please.");
        double thirdN = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert fourth's c value, please.");
        double fourthN = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert fifth's c value, please.");
        double fifthN = double.Parse(Console.ReadLine());

        Console.WriteLine("| {0} {1} {2} {3} {4} | {5} |", firstN, SecondN, thirdN, fourthN, fifthN, firstN + SecondN + thirdN + fourthN + fifthN);


    }
}||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Sum of 5 Numbers
*Write a program that enters 5 numbers (given in a single line, separated by 
a space), calculates and prints their sum.
_Examples:_
|      numbers      |  sum  |
|-------------------|-------|
| 1 2 3 4 5         | 15    |
| 10 10 10 10 10    | 50    |
| 1.5 3.14 8.2 -1 0 | 11.84 |

-------------------------------------------------------------------------------
Solution:

"); 
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert first number's, please.");
        double firstN = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number's, please.");
        double SecondN = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert third number's, please.");
        double thirdN = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert fourth's c value, please.");
        double fourthN = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert fifth's c value, please.");
        double fifthN = double.Parse(Console.ReadLine());

        Console.WriteLine("| {0} {1} {2} {3} {4} | {5} |", firstN, SecondN, thirdN, fourthN, fifthN, firstN + SecondN + thirdN + fourthN + fifthN);


    }
}>>>>>>> .r6
