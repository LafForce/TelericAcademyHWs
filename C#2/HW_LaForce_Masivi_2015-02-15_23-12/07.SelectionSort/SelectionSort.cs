using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(@"Problem 7. Selection sort
Sorting an array means to arrange its elements in increasing order. 
Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the
first position, find the smallest from the rest, move it at the second 
position, etc.
============================================================================
Solution:");

        //obtaining an array to be sort:
        Console.WriteLine("How many elements will you enter?");
        int n = int.Parse(Console.ReadLine().ToString());

        int[] array = new int[n];

        Console.WriteLine("Enter the numbers each on a seperate line, please.");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine().ToString());
        }

        //the check and assignment to the sorted array:
        int min;
        for (int i = 0; i < array.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            (array[min], array[i]) = (array[i], array[min]);
        }
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}
