

//
//{
//    static void Main()
//    {
//        System.Console.WriteLine(@"Problem 18.* Remove elements from array
//        Write a program that reads an array of integers and removes from it a 
//        minimal number of elements in such a way that the remaining array is 
//        sorted in increasing order.
//        Print the remaining sorted array.
//        Example:
//        input	                        result
//        6, 1, 4, 3, 0, 3, 6, 4, 5	1, 3, 3, 4, 5
//        ============================================================================
//        Solution:");
//        //the input:
//        // imputed unsorted array:


//        //manual imput?:


      
//        List<string> current = new List<string>();
 
//        for (int i = 0; i <= numbers.Length; i++)
//        {
            
//        }


//    }
//}
﻿//Problem 18.* Remove elements from array
//Write a program that reads an array of integers and removes from it a minimal number of 
//elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

//Example:
//input 	                                      result
//6, 1, 4, 3, 0, 3, 6, 4, 5 	                  1, 3, 3, 4, 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class subsetKSumS
{
           

    static void Main()
    {
    Console.WriteLine(@"Problem 18.* Remove elements from array
Write a program that reads an array of integers and removes from it a 
minimal number of elements in such a way that the remaining array is 
sorted in increasing order.
Print the remaining sorted array.
Example:
input	                        result
6, 1, 4, 3, 0, 3, 6, 4, 5	1, 3, 3, 4, 5
============================================================================
Solution:");

        List<int> leftToChk = new List<int>();
        leftToChk.Add(-1);

        Console.WriteLine("Insert unsorted array on the fowolling row, please.");
        int[] numbers = Console.ReadLine().Split(new char[] { ' ', '.', '\t', ',' }
            , StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        int firstDigit = new int();
        int secondDigit = new int();


        int leftInd = 0;
        int rightInd = 1;
        int final = numbers.Length - 1;

        int listCount = 0;


        for (int i = leftInd, j = rightInd; i < final; i += 2, j += 2)
        {
            firstDigit = numbers[i];
            secondDigit = numbers[j];
            if (firstDigit >= secondDigit && secondDigit >= leftToChk[listCount])
            {

                leftToChk.Add(secondDigit);
                listCount++;
            }
            else if (firstDigit <= secondDigit && firstDigit <= leftToChk[listCount])
            {
                leftToChk.Add(secondDigit);
                listCount++;
            }
            if (i == final - 2)
            {
                firstDigit = numbers[numbers.Length - 1];
                secondDigit = numbers[numbers.Length - 2];
                if (secondDigit <= firstDigit)
                {
                    leftToChk.Add(firstDigit);
                }
            }

        }

        for (int i = 1; i < leftToChk.Count; i++)
        {
            Console.Write(leftToChk[i] + " ");
        }

    }
}