using System;
using System.Linq;
class SortingArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 9. Sorting array
Write a method that return the maximal element in a portion of array of 
integers starting at given index. Using it write another method that sorts
an array in ascending / descending order.
============================================================================
Solution:");

        //obtaining an array to be sort:

        ////Manual imput:
        //Console.WriteLine("Insert int array on 1 line coma separated numbers, please");
        //int[] arr = Console.ReadLine()
        //    .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
        //    .Select(x => int.Parse(x))
        //    .ToArray();



        int[] arr = { 3, 5, 3, -2, 45, -3 - 6, 7, -5, -9, 76, -7, 78, -9, 8, 7 - 23, 3, 4, 5, 9, 0 };
        
        
        
        Console.Write("The entered numers are { ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }
        Console.WriteLine("}");
        Console.WriteLine();

        Console.WriteLine("The start index is: ");
        int index = int.Parse(Console.ReadLine());

        int answer = Chk(arr, index);
        Console.WriteLine("The max element is: {0} at index {1}", arr[answer], answer);
        
        
        Console.WriteLine();
        Console.WriteLine("Descending sorted:");
        SortItDesc(arr);
        Console.WriteLine(String.Join(", ",arr));

        Console.WriteLine();
        Console.WriteLine("Ascending sorted:");
        
        Console.WriteLine(String.Join(", ", SortItAsc(arr)));

    }

    static int  Chk(int[] arr, int index)
    {
        int max = index;
        int maxValue = int.MinValue;
        for (int i = index; i < arr.Length; i++)
        {
                if (arr[i] > arr[max])
                {
                    maxValue = arr[i];
                    max = i;
                }
            
        }
        return max;
    }

    static int[] SortItDesc(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int max = Chk(arr, i);
            int temp = arr[i];
            arr[i] = arr[max];
            arr[max] = temp;
        }
        return arr;
    }
    static int[] SortItAsc(int[] arr)
    {
        int[] newArr = new int[arr.Length];
       for (int i = 0; i < arr.Length; i++)
       {
          newArr[i] = arr[arr.Length - i -1];
       }
       return newArr;
    }
}