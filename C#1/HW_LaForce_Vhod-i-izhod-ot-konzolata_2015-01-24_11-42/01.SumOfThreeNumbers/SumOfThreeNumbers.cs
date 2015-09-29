<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;



class SumOfThreeNumbers
{

    static void Main()
    {
        Console.WriteLine(@"Problem:
Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum.
_Examples:_
|      a      |   b  |   c  |  sum |
|:-----------:|:----:|:----:|:----:|
| 3           | 4    | 11   | 18   |
| -2          | 0    | 3    | 1    |
| 5.5         | 4.5  | 20.1 | 30.1 |

-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert number's a value, please.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's b value, please.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's c value, please.");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of a = {0}, b = {1}, and c = {2} is {3}", a, b, c, a + b + c);

    }
}
||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;



class SumOfThreeNumbers
{

    static void Main()
    {
        Console.WriteLine(@"Problem:
Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum.
_Examples:_
|      a      |   b  |   c  |  sum |
|:-----------:|:----:|:----:|:----:|
| 3           | 4    | 11   | 18   |
| -2          | 0    | 3    | 1    |
| 5.5         | 4.5  | 20.1 | 30.1 |

-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert number's a value, please.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's b value, please.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's c value, please.");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of a = {0}, b = {1}, and c = {2} is {3}", a, b, c, a + b + c);

    }
}
>>>>>>> .r6
