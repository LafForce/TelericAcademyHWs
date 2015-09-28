using System;
using System.Globalization;
using System.Threading;
class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Zero Subset
*We are given 5 integer numbers. Write a program that finds all subsets of
these numbers whose sum is 0.
*Assume that repeating the same subset several times is not a problem.
_Examples:_
| numbers       | result                |
|---------------|-----------------------|
| 3  -2  1  1 8 | -2 + 1 + 1 = 0        |
|               |                       |
| 3 1 -7 35 22  | no zero subset        |
|               |                       |
| 1 3 -4 -2 -1  | 1 + -1 = 0            |
|               | 1 + 3 + -4 = 0        |
|               | 3 + -2 + -1 = 0       |
|               |                       |
| 1 1 1 -1 -1   | 1 + -1 = 0            |
|               | 1 + 1 + -1 + -1 = 0   |
|               |                       |
| 0 0 0 0 0     | 0 + 0 + 0 + 0 + 0 = 0 |
_Hint: you may check for zero each of the 32 subsets with 32 `if` statements._
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


        Console.WriteLine("insert number a, please");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("insert number b, please");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("insert number c, please");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("insert number d, please");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("insert number e, please");
        int e = int.Parse(Console.ReadLine());


        string razdelitel = new String('=', 38);
        Console.WriteLine(razdelitel);
        bool subsets = false;


        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1}", a, b);
            subsets = true;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1}", a, c);
            subsets = true;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1}", a, d);
            subsets = true;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1}", a, e);
            subsets = true;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1}", b, c);
            subsets = true;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1}", b, d);
            subsets = true;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1}", b, e);
            subsets = true;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1}", c, d);
            subsets = true;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1}", c, e);
            subsets = true;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1}", d, e);
            subsets = true;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, b, c);
            subsets = true;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, b, d);
            subsets = true;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, b, e);
            subsets = true;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, c, d);
            subsets = true;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, c, e);
            subsets = true;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, d, e);
            subsets = true;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, c, e);
            subsets = true;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", b, c, d);
            subsets = true;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", b, c, e);
            subsets = true;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", b, d, e);
            subsets = true;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", c, d, e);
            subsets = true;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}", a, b, c, d);
            subsets = true;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}+ {3}", a, b, c, e);
            subsets = true;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}+ {3}", a, c, d, e);
            subsets = true;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}+ {3}", b, c, d, e);
            subsets = true;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}+ {3}+ {4}", a, b, c, d, e);
            subsets = true;
        }
        if (subsets == false)
        {
            Console.WriteLine("no zero subset ");
        }
    }
}

