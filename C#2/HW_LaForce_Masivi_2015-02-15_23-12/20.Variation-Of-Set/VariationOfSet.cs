using System;

public class VariationsWithReps
{


    private static int[] numbers;
    private static int n;
    private static int k;
    static void Main()
    {
        Given();

        string numberN;

        do
        {
            Console.Write("Please insert the size of the set (N).");
            numberN = Console.ReadLine();
        }
        while (!Int32.TryParse(numberN, out n) || n <= 0);

        string numberK;

        do
        {
            Console.Write("Please insert number to be varied (K).");
            numberK = Console.ReadLine();
        }
        while (!Int32.TryParse(numberK, out k) || k <= 0 || k > n);

        numbers = new int[n];

        Console.WriteLine("Result : ({0}, {1}):", n, k);

        Variate(0);
    }
    static void Given()
    {
        System.Console.WriteLine(@"Problem 20. Variations of set
Write a program that reads two numbers N and K and generates all the
variations of K elements from the set [1..N].
Example:
N	K	result
3	2	{1, 1} 
{1, 2} 
{1, 3} 
{2, 1} 
{2, 2} 
{2, 3} 
{3, 1} 
{3, 2} 
{3, 3}
============================================================================
Solution:");
    }

    private static void Print(int i)
    {
        for (int j = 0; j <= i - 1; j++)
        {
            Console.Write("{0} ", numbers[j] + 1);
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Recursively generates the k-element variations
    /// of the numbers from 0 to (n-1) (incremented with 1
    /// when printed).
    /// </summary>
    /// <param name="i"></param>
    private static void Variate(int i)
    {
        if (i >= k)
        {
            Print(i);
            return;
        }

        for (int j = 0; j < n; j++)
        {
            numbers[i] = j;
            Variate(i + 1);
        }
    }

}