using System;
using System.Linq;
testit

class AppCount
{
    static void Main()
    {
        Console.WriteLine(@"Problem 4. Appearance count
Write a method that counts how many times given number appears in given 
array.
Write a test program to check if the method is workings correctly.
============================================================================
Solution:");
        Console.WriteLine("Insert int array on 1 line coma separated numbers, please");
        int[] arr = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        Console.WriteLine("Which number are we counting?");
        int num = int.Parse(Console.ReadLine().ToString());

        Console.WriteLine(Counter(arr, num));

        Console.WriteLine();
    }
    static int Counter(int[] arr, int num)
    {
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
              if (num == arr[i])
                {
                    counter++;
                }
            
        }
        return counter;
    }
}
