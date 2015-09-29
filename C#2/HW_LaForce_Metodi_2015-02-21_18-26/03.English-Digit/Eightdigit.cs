using System;

class Eightdigit
{
    static void Main()
    {
        Console.WriteLine(@"Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
Examples:
input	output
512	two
1024	four
12309	nine	
============================================================================
Solution:");

        Console.WriteLine("Insert a number:");

        int num = int.Parse(Console.ReadLine().ToString());

        Console.WriteLine();
        Console.WriteLine("Result:");
        Console.WriteLine(SayIt(num));

        Console.WriteLine();
    }


    static string SayIt(int num)
    {
        int number = num % 10;


        if (number == 0)
        {
            return "Zero";
        }
        else if (number == 1)
        {
            return "One";
        }
        else if (number == 2)
        {
            return "Two";
        }
        else if (number == 3)
        {
            return "Three";
        }
        else if (number == 4)
        {
            return "Four";
        }

        else if (number == 5)
        {
            return "Five";
        }

        else if (number == 6)
        {
            return "Six";
        }
        else if (number == 7)
        {
            return "Seven";
        }
        else if (number == 8)
        {
            return "Eight";
        }
        else if (number == 9)
        {
            return "Nine";
        }
        else
            return "something's wrong";
    }
}
