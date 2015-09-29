using System;
using System.Linq;
class IntCalc
{
    static void Main()
    {
        Console.WriteLine(@"Problem 14. Integer calculations
Write methods to calculate minimum, maximum, average, sum and product of 
given set of integer numbers.
Use variable number of arguments.
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

    static void Minimum(int[] arr)
    {
        int min = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < arr[min])
            {
                min = i;
            }
        }
        Console.WriteLine("The min value is : {0}", arr[min]);
    }

    static void Maximum(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > arr[max])
            {
                max = i;
            }

        }
        Console.WriteLine("The max value is : {0}", arr[max]);
        Console.WriteLine();
    }
    static void Average(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine();
        double average = (double)sum / (numbers.Length);

        Console.WriteLine("The average value is : {0}", average);
        Console.WriteLine();
    }
    static void Sum(int[] numbers)
    {

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("The sum value is : {0}", sum);
        Console.WriteLine();
    }
    static void Product(int[] numbers)
    {
        int prod = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            prod *= numbers[i];
        }
        Console.WriteLine("The product value is : {0}", prod);

    }
}
