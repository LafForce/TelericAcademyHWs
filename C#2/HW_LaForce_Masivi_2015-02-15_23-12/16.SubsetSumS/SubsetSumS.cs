using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSumS
{
    static void Main()
    {
        System.Console.WriteLine(@"Problem 16.* Subset with sum S
We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the 
array that has a sum S.
Example:
input array	S	result
2, 1, 2, 4, 3, 5, 2, 6	14	yes
============================================================================
Solution:");
        //get data:
        Console.WriteLine("Insert secquence of separated integers on the fowolling row, please.");

        int[] numberSequ = Console.ReadLine().Split(new char[] { ' ', ',', '\t', '.' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x)).OrderBy(x => x).ToArray();

        Console.WriteLine("Insert the sum S you are interested in, please.");
        int sumS = int.Parse(Console.ReadLine().ToString());
        Console.WriteLine();

        //chk:
        int currentsum = 0;
        bool isThere = false;
        for (int i = 0; i < numberSequ.Length; i++)
        {
            currentsum = numberSequ[i];

            if (currentsum == sumS)
            {
                isThere = true;
                break;
            } 

            for (int j = i + 1; j < numberSequ.Length; j++)
            {
                currentsum += numberSequ[j];

                if (currentsum == sumS)
                {
                    isThere = true;
                    break;
                }
            }
        }

        //display:
        Console.WriteLine("There is such subset: {0}", isThere ? "Yes" : "No");
    }
}