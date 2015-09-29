using System;
using System.Collections.Generic;
using System.Linq;

class BinSearch
{
    static void Main()
    {
        System.Console.WriteLine(@"Problem 11. Binary search
Write a program that finds the index of given element in a sorted array of 
integers by using the Binary search algorithm.
============================================================================
Solution:");

        //manual imputed sorted array:
        int[] inputArray = { 1, 2, 4, 5, 6, 10, 12, 13, 14, 15, 16, 18, 20, 25, 30, 33, 34, 35, 36, 50, 202, 220, 222, 300 };
        
        //Console.WriteLine(inputArray.Length);


        //Console.WriteLine("Insert sorted array on the fowolling row, please.");
        //    //it also sorts in case the user is mischievous:
        //int[] inputArray = Console.ReadLine().Split(new char[] { ' ', '.', '\t', ',' }
        //    , StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).OrderBy(x => x).ToArray();

        Console.WriteLine("Insert the number you are interested in, please.");
        int number = int.Parse(Console.ReadLine().ToString());
        Console.WriteLine();

        //the check:
        int min = 0;
        int max = inputArray.Length;

        while (min <= max)
        {
            int mid = ((min + max) / 2);

            if (number == inputArray[mid])
            {
                Console.WriteLine("The value has the index {0} in this array.", mid);
                break;
            }
            else if (number < inputArray[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        if (min > max)
        {
            Console.WriteLine("No such value in this array");
        }
        
    }
}