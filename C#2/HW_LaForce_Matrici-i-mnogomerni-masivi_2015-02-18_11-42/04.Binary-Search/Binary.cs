using System;
using System.Linq;
class Program
{
    static void Main()
    {

        Console.WriteLine(@"Problem 4. Binary search
Write a program, that reads from the console an array of N integers and an 
integer K, sorts the array and using the method Array.BinSearch() finds the 
largest number in the array which is ≤ K.
============================================================================
Solution:

");//manual imputed sorted array:
        int[] inputArray = { 1, 2, 4, -5, 6, 10, 12, 13, -14, 15, 16, 18, 20, -25, 30, 33, 34, 35, 36, -50, 202, 220, 222, 300 };
        
        //Console.WriteLine(inputArray.Length);


        //Console.WriteLine("Insert sorted array on the fowolling row, please.");
        ////it also sorts in case the user is mischievous:
        //int[] inputArray = Console.ReadLine().Split(new char[] { ' ', '.', '\t', ',' }
        //    , StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
        Console.WriteLine("The unsorted array is:");
        foreach (int x in inputArray)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Insert the number K, please.");
        int numberK = int.Parse(Console.ReadLine().ToString());

        int[] theArray = new int[inputArray.Length + 1];
        theArray[0] = numberK;
        for (int i = 1; i < theArray.Length; i++)
        {
            theArray[i] = inputArray[i - 1];
        }
        Array.Sort(theArray);

        Console.WriteLine("The sorted array (+K) is:");
        foreach (int x in theArray)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        Console.WriteLine();


        //the check:
        int min = 0;
        int max = theArray.Length;

        while (min <= max)
        {
            int mid = ((min + max) / 2);

            if (numberK == theArray[mid])
            {
            hereHereBoy:

                if (mid == 0)
                {
                    Console.WriteLine("There is no number which is smaller than {0} in this array", numberK);
                    break;
                }
                if (theArray[mid - 1] == numberK)
                {
                    mid -= 1;
                    goto hereHereBoy;
                }
               
                    Console.WriteLine("The largest number in the array which is less than {1} is {0}.", theArray[mid - 1], numberK);
                    break;
            }
            else if (numberK < theArray[mid])
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
