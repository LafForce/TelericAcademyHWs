using System;
using System.Linq;
class NumberCalc
{
    static void Main()
    {
        Console.WriteLine(@"Problem 15.* Number calculations
Modify your last program and try to make it work for any number type, 
not just integer (e.g. decimal, float, byte, etc.)
Use generic method (read in Internet about generic methods in C#).
============================================================================
Solution:");

        
        Console.WriteLine();
    
           //the number of arguments can be varied at Input

        //Console.WriteLine(@"Insert sequence of int to manipulate...");
        //Console.WriteLine("on 1 row, coma separated, please: ");
        //int[] numbers = Console.ReadLine()
        //            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
        //            .Select(x => int.Parse(x))
        //            .ToArray();


        //Automated input:
        int[] numbers = { -3, 34, 1, -1, 2, 45, 5, 65, 23 };

        Console.Write("The numers are { ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}, ", numbers[i]);
        }
        Console.WriteLine("}");
        Console.WriteLine();

        Minimum(numbers);

        Maximum(numbers);

        Average(numbers);

        Sum(numbers);

        Product(numbers);

        Console.WriteLine();
    }

    static void Minimum<T>(params T[] arr) 
        where T : IComparable
    {
        int min = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(arr[min]) == -1) min = i;
        }
        
        Console.WriteLine("The min value is : {0}", arr[min]);
        Console.WriteLine();
    }

    static void Maximum<T>(params T[] arr) 
    where T : IComparable
    {
        int maxIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(arr[maxIndex]) == 1) maxIndex = i;
        }
        Console.WriteLine("The max value is : {0}", arr[maxIndex]);
        Console.WriteLine();
    }
    static void Average<T>(params T[] numbers)
    where T : IComparable
    {
        Console.WriteLine("The average value is : {0}", numbers.Aggregate<T, dynamic>(0, (current, t) => current + t)); 
        Console.WriteLine();
    }
    static void Sum<T>(params T[] numbers)
    where T : IComparable

    {
        Console.WriteLine("The sum is : {0}", numbers.Aggregate<T, dynamic>(0, (current, t) => current + t));
        Console.WriteLine();
    }
    static void Product<T>(params T[] numbers)
    where T : IComparable

    {
        Console.WriteLine("The product is : {0}", numbers.Aggregate<T, dynamic>(0, (current, t) => current * t));
        Console.WriteLine();
    }
}

