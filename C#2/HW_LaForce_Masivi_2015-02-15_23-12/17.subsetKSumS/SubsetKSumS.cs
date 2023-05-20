using System;
using System.Collections.Generic;
using System.Linq;

class subsetKSumS
{
    static void Main()
    {
        System.Console.WriteLine(@"Problem 17.* Subset K with sum S
Write a program that reads three integer numbers N, K and S and an array 
of N elements from the console. Find in the array a subset of K elements 
that have sum S or indicate about its absence.
============================================================================
Solution:");



        //get data:
        Console.WriteLine("Insert secquence of more than 2 numbers on the fowolling row, please.");
        int[] numberSequ = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x)).OrderBy(x => x).ToArray();

        Console.WriteLine("Insert the sum S you are interested in, please.");
        int sumS = int.Parse(Console.ReadLine().ToString());
        Console.WriteLine();

        Console.WriteLine("Insert the number of elements to form the sum, please.");
        int length = int.Parse(Console.ReadLine().ToString());
        Console.WriteLine();

        //foreach (int number in numberSequ)
        //{
        //    Console.Write(number + ", ");
        //}

        //chk:
        bool thereIs = false;
        int currentsum = 0;

        for (int i = 0; i < numberSequ.Length; i++)
        {
            currentsum = numberSequ[i];

            if (currentsum == sumS)
            {
                thereIs = true;
                break;
            }

            for (int j = i + 1; j < length - 1; j++)
            {
                currentsum += numberSequ[j];

                if (currentsum == sumS)
                {
                    thereIs = true;
                    break;
                }
            }
        }

        //display:
        Console.WriteLine("Is there subsum {1} of {2} elements in the array: {0}", thereIs ? "Yes" : "No", sumS, length);

    }
}
