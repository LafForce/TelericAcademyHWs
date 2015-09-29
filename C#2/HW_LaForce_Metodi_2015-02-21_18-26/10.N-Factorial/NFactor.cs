using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
class NFactor
{
    static void Main()
    {
        Console.WriteLine(@"Problem 10. N Factorial
Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as 
array of digits by given integer number.
============================================================================
Solution:");

        Console.Write("Insert number between 1 and 100 to find its factorial: ");
        int num = int.Parse(Console.ReadLine());

        List<int> factorial = Nfact(num);
        Console.WriteLine("The factorial of number {0} is: {1}", num, string.Join("", factorial));
    }

    static List<int> Nfact(int n)
    {
        int[] a = { 1 };
        int left = 0;
        for (int i = 2; i <= n; i++, left = 0)
        {
            int[] b = i.ToString().Select(ch => ch - '0').ToArray();
            int[] c = new int[a.Length + b.Length];
            for (int k = a.Length - 1; k >= 0; k--)
            {
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    c[a.Length - k + b.Length - j - 2] += a[k] * b[j];
                }
            }

            for (int j = 0; j < c.Length; j++)
            {
                var digits = c[j] + left;
                c[j] = digits % 10;
                left = digits / 10;
            }
            a = c;
            Array.Reverse(c);
        }

        int start = 0;
        while (a[start] == 0) start++;

        List<int> result = new List<int>();
        for (int i = start; i < a.Length; i++)
        {
            result.Add(a[i]);
        }
        return result;
    }
}