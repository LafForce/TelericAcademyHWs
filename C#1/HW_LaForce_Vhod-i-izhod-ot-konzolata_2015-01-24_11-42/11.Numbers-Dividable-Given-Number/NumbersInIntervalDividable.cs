<<<<<<< .mine
﻿using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Numbers in Interval Dividable by Given Number
*	Write a program that reads two positive integer numbers and prints how 
many numbers `p` exist between them such that the reminder of the division
by `5` is `0`.
_Examples:_
| start | end |  p |                       comments       
|:-----:|:---:|:--:|-------------------------------------------------------|
| 17    | 25  | 2  | 20, 25                                                |
| 5     | 30  | 6  | 5, 10, 15, 20, 25, 30                                 |
| 3     | 33  | 6  | 5, 10, 15, 20, 25, 30                                 |
| 3     | 4   | 0  | -                                                     |
| 99    | 120 | 5  | 100, 105, 110, 115, 120                               |
| 107   | 196 | 18 | 110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160,
165, 170, 175, 180, 185, 190, 195 |
-------------------------------------------------------------------------------
Solution:

");
        //Get the number to be checked:
        Console.WriteLine("At which number do you want the check to start");
        int divStart = int.Parse(System.Console.ReadLine());
        Console.WriteLine("and to end");
        int divEnd = int.Parse(System.Console.ReadLine());

        //declaring needed variables:
        string theNumbers = null;
        int numberC = 0;
        
        //the check and storing results to local:
        for (int i = divStart; i <= divEnd; i++)
        {
            if (i % 5 == 0)
            {
                theNumbers += (" " + i + ", ");
                numberC++;
            }
        }

        //Output (I know it can be done beautifully but had no nerve for that):
        Console.WriteLine("|{0,-8}|{1,-8}|{2,-5}|{3,-34}|", "start", "end", 'p', "divisors:");
        Console.Write("|{0,8}|{1,8}|{2,5}|{3,-34}|", divStart, divEnd, numberC, theNumbers);
    }
}
||||||| .r0
=======
﻿using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Numbers in Interval Dividable by Given Number
*	Write a program that reads two positive integer numbers and prints how 
many numbers `p` exist between them such that the reminder of the division
by `5` is `0`.
_Examples:_
| start | end |  p |                       comments       
|:-----:|:---:|:--:|-------------------------------------------------------|
| 17    | 25  | 2  | 20, 25                                                |
| 5     | 30  | 6  | 5, 10, 15, 20, 25, 30                                 |
| 3     | 33  | 6  | 5, 10, 15, 20, 25, 30                                 |
| 3     | 4   | 0  | -                                                     |
| 99    | 120 | 5  | 100, 105, 110, 115, 120                               |
| 107   | 196 | 18 | 110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160,
165, 170, 175, 180, 185, 190, 195 |
-------------------------------------------------------------------------------
Solution:

");
        //Get the number to be checked:
        Console.WriteLine("At which number do you want the check to start");
        int divStart = int.Parse(System.Console.ReadLine());
        Console.WriteLine("and to end");
        int divEnd = int.Parse(System.Console.ReadLine());

        //declaring needed variables:
        string theNumbers = null;
        int numberC = 0;
        
        //the check and storing results to local:
        for (int i = divStart; i <= divEnd; i++)
        {
            if (i % 5 == 0)
            {
                theNumbers += (" " + i + ", ");
                numberC++;
            }
        }

        //Output (I know it can be done beautifully but had no nerve for that):
        Console.WriteLine("|{0,-8}|{1,-8}|{2,-5}|{3,-34}|", "start", "end", 'p', "divisors:");
        Console.Write("|{0,8}|{1,8}|{2,5}|{3,-34}|", divStart, divEnd, numberC, theNumbers);
    }
}
>>>>>>> .r6
