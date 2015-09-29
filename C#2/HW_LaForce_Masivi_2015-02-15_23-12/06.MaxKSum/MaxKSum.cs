using System;

class MaxSum
{

    static void Main(string[] args)
    {
        System.Console.WriteLine(@"Problem 6. Maximal K sum
Write a program that reads two integer numbers N and K and an array of N 
elements from the console.
Find in the array those K elements that have maximal sum.
============================================================================
Solution:");

        //Input data colection:
        Console.WriteLine("Enter number of elements N, please.");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter number of elements to be summed up \"K\", please.");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} integers on sepparate rows, please.", n);
        
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //the check:
        int sum = 0;
        int position = 0;
        int totalSum = int.MinValue;

        for (int i = 0; i <= n - k; i++)
        {
            for (int j = 1; j <= k; j++)
            {
                sum += arr[i + j -1];
            }
            if (totalSum < sum)
            {
                totalSum = sum;
                position = i;
            }
            sum = 0;
        }
        
        //the display:
        Console.WriteLine();
        for (int i = position; i < position + k -1; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }
        Console.WriteLine(arr[position + k - 1]);
    }
}