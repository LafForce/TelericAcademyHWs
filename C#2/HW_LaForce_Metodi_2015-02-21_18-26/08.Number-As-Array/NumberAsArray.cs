using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 8. Number as array
Write a method that adds two positive integer numbers represented as 
arrays of digits (each array element arr[i] contains a digit; the last 
digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits
============================================================================
Solution:");

        Console.Write("Enter the first number to be added: ");
        string first = Console.ReadLine();

        Console.Write("Enter the second numberto be added: ");
        string second = Console.ReadLine();

        if (IsCorrectNumber(first) && IsCorrectNumber(second))
        {
            List<int> result = AccumulateTwoNumbers(first, second);
            Console.Write("The added numbers are equal to: ");
            PrintResult(result);
        }
        else
        {
            Console.WriteLine("Something's worng here!");
        }
    }

    static bool IsCorrectNumber(string number)
    {
        return number.All(t => t >= '0' && t <= '9');
    }

    static List<int> AccumulateTwoNumbers(string first, string second)
    {
        var firstNumArr = first.Select(ch => ch - '0').ToArray();
        var secondNumArr = second.Select(ch => ch - '0').ToArray();

        Array.Reverse(firstNumArr);
        Array.Reverse(secondNumArr);

        List<int> result = new List<int>(Math.Max(firstNumArr.Length, secondNumArr.Length));

        int left = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int num = (i < firstNumArr.Length ? firstNumArr[i] : 0) + (i < secondNumArr.Length ? secondNumArr[i] : 0) + left;
            left = num / 10;
            result.Add(num % 10);
        }

        if (left > 0) result.Add(left);
        return result;
    }

    static void PrintResult(List<int> result)
    {
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine("\n");
    }
}