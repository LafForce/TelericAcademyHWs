using System;
using System.Linq;
class AllocateArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 6. First larger than neighbours
Write a method that returns the index of the first element in array that 
is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.		
============================================================================
Solution:");
        Console.WriteLine("Insert int array on 1 line coma separated numbers, please");

        //
        
        //manual imput:
        //int[] arr = Console.ReadLine()
        //    .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
        //    .Select(x => int.Parse(x))
        //    .ToArray();

        int[] arr = { 3, 5, 3, -2, 45, -3 - 6, 7, -5, -9, 76, -7, 78, -9, 8, 7 - 23, 3, 4, 5, 9, 0 }; ;

        int index = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (IsIt(arr, i))
            {
                index = i;
                break;
            }
        }
        if (index == -1)
        {
            Console.WriteLine();
            Console.WriteLine("No such element in this array: ");
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("The element {0} at position {1} is the first bigger than neighbours in the array!", arr[index], index);
            Console.WriteLine();
        }
    }
    static bool IsIt(int[] arr, int pos)
    {
        bool isIt = false;
        if ((pos - 1) >= 0 && ((pos + 1) < arr.Length))
        {
            if (arr[pos - 1] <= arr[pos] && arr[pos + 1] <= arr[pos])
            {
                isIt = true;
                return isIt;
            }
        }
        return isIt;
    }
}