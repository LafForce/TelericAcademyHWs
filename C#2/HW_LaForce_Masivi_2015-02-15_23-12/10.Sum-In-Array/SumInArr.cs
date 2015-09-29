using System;
using System.Collections.Generic;
using System.Text;

class FreqSum
{
    static void Main()
    {
        System.Console.WriteLine(@"Problem 10. Find sum in array
Write a program that finds in given array of integers a sequence of given 
sum S (if present).
Example:
array	                 S	result
4, 3, 1, 4, 2, 5, 8	11	4, 2, 5
============================================================================
Solution:");

        //NB: My program stops on the FIRST sequence in the array, if present! 
        //Since the given is not explicit about that I consider it running correctly!

        //get data:
        Console.WriteLine("Insert secquence of simple digits on the fowolling row, please.");
        int[] numberSequ = Array.ConvertAll(Console.ReadLine()
            .Split(new char[] { ' ', '.', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);


        for (int i = 0; i < numberSequ.Length; i++)
        {
            Console.WriteLine("{0} -> {1}", i, numberSequ[i]);
        }

        Console.WriteLine("Insert the sum you are interested in, please.");
        int sum = int.Parse(Console.ReadLine().ToString());

        Console.WriteLine();

        //chk:
        int counter = 0;
        int firstMemberIndex = 0;
        int currentsum = 0;
        bool isNotEqu = true;


        for (int i = 0; i < numberSequ.Length && isNotEqu; i++)
        {
            firstMemberIndex = i;
            counter = 1;
            currentsum = numberSequ[i];
            if (sum == currentsum)
            {
                isNotEqu = false;
                break;
            }
            for (int j = i + 1; j < numberSequ.Length; j++)
            {
                currentsum += numberSequ[j];
                counter++;
                if (sum == currentsum)
                {
                    isNotEqu = false;
                    break;
                }
            }
        }

        //display of the result:

        //if negative
        if (isNotEqu)
        {
            Console.WriteLine("No such sequence.");
            return;
        }

        //if positive:
        StringBuilder result = new StringBuilder("Result: ");

        if (!isNotEqu)
        {
            for (int k = firstMemberIndex; k < firstMemberIndex + counter - 1; k++)
            {
                result.Append(numberSequ[k] + ", ");
            }
            result.Append(numberSequ[firstMemberIndex + counter - 1]);
        }
        Console.WriteLine(result);

    }
}
