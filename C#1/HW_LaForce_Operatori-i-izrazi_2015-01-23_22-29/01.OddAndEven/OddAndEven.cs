<<<<<<< .mine
﻿using System;

//### Problem 1.	Odd or Even Integers
//*	Write an expression that checks if given integer is odd or even.

//_Examples:_

//|  n |  Odd? |
//|:--:|:-----:|
//| 3  | true  |
//| 2  | false |
//| -2 | false |
//| -1 | true  |
//| 0  | false |


class OddAndEven
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Odd or Even Integers
Write an expression that checks if given integer is odd or even
---------------------------------------------------------------
Solution:

");
        Console.WriteLine("Inset number, please");
        int numerToBeChk = int.Parse(Console.ReadLine());

        bool isOdd = ((numerToBeChk % 2) != 0);
        Console.WriteLine("The number {0} is: {1}!", numerToBeChk, isOdd ? "odd" : "even");
    }
}

||||||| .r0
=======
﻿using System;

//### Problem 1.	Odd or Even Integers
//*	Write an expression that checks if given integer is odd or even.

//_Examples:_

//|  n |  Odd? |
//|:--:|:-----:|
//| 3  | true  |
//| 2  | false |
//| -2 | false |
//| -1 | true  |
//| 0  | false |


class OddAndEven
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Odd or Even Integers
Write an expression that checks if given integer is odd or even
---------------------------------------------------------------
Solution:

");
        Console.WriteLine("Inset number, please");
        int numerToBeChk = int.Parse(Console.ReadLine());

        bool isOdd = ((numerToBeChk % 2) != 0);
        Console.WriteLine("The number {0} is: {1}!", numerToBeChk, isOdd ? "odd" : "even");
    }
}

>>>>>>> .r6
