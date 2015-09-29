using System;
using System.Linq;
class LargerThan
{
    static void Main()
    {
        Console.WriteLine(@"Problem 5. Larger than neighbours
Write a method that checks if the element at given position in given array
of integers is larger than its two neighbours (when such exist).
============================================================================
Solution:");
        Console.WriteLine("Insert int array on 1 line coma separated numbers, please");
        int[] arr = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();


        Console.WriteLine("Which is the position in the array of the number to be checked?");
        int num = int.Parse(Console.ReadLine().ToString());

        Console.Write("Is it bigger than neighbours: ");
        Console.WriteLine( "{0}", IsIt(arr, num) ? "yes" : "no");
        
        Console.WriteLine();
    }
   
    
    static bool IsIt(int[] arr, int pos)
    {
        bool isIt = false;
        if ((pos - 1) >= 0 && ((pos + 1 ) <= arr.Length))
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
