using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class QuickSort
{
    static void Main(string[] args)
    {
        //Print the given of the task:
        Given();

        // Input an unsorted array of string elements:
        Console.WriteLine("Input an unsorted array of comma separated string elements, please.");
        //string[] array = Console.ReadLine().Split(new string[] {" ", ",", ".", "\t"}, StringSplitOptions.RemoveEmptyEntries);
        //Console.WriteLine();

        ////Ready input:
        string[] array = { "one", "z", "nice", "asdf", "e", "x", "c", "cool", "m", "q", "a" };
        Console.WriteLine();

        // Print the unsorted array
        Console.WriteLine("Input:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Sort the array
        Quicksort(array, 0, array.Length - 1);

        // Print the sorted array
        Console.WriteLine("Result:");
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    //the sort:
    public static void Quicksort(string[] elements, int left, int right)
    {
        int i = left, j = right;
        string pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                string tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
        static void Given()
        {
                Console.WriteLine(@"Problem 14. Quick sort
Write a program that sorts an array of integers using the Quick sort 
algorithm.
============================================================================
Solution:");
                Console.WriteLine();
        }

}
