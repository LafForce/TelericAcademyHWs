using System;
using System.Collections.Generic;
class MaxIncreaseSeqe
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(@"Problem 5. Maximal increasing sequence
*Write a program that finds the maximal increasing sequence in an array.
_Example:_
|          input          | result  |
|-------------------------|---------|
| 3, **2, 3, 4**, 2, 2, 4 | 2, 3, 4 |
============================================================================
Solution:");

        ////Automatic input?:
        //List<int> numberSeq = new List<int> { 3, 2, 3, 4, 2, 2, 4 };
        //List<int> numberSeq = new List<int> { 5, 6, 7, 8, 9, 0, 3, 2, 3, 4, 2, 2, 4 };


        //getting the array(in case automatic coment this)
        Console.WriteLine("Insert secquence of simple digits on the fowolling row, please.");
        char[] seque = Console.ReadLine().ToCharArray();

        //to int list:
        List<int> numberSeq = new List<int>();
        for (int i = 0; i < seque.Length; i++)
        {
            if (Char.IsNumber(seque[i]))
            {
                numberSeq.Add((int)Char.GetNumericValue(seque[i]));
            }
        }
        //(end of manual input... sohould be commented)

        ////display of the array...:
        //for (int i = 0; i < numberSeq.Count; i++)
        //{
        //    Console.WriteLine(numberSeq[i]);
        //}


        //the check;
        short counter = 0;
        int totalCount = 0;
        int finalLast = 0;

        for (int k = 1; k < numberSeq.Count; k++)
        {
            if (numberSeq[k - 1] == numberSeq[k] - 1)
            {
                counter++;
                if (totalCount < counter)
                {
                    totalCount = counter;
                    finalLast = numberSeq[k];
                }
            }
            else
            {
                counter = 0;
            }
        }
        ////result check, it should be irrelevant to you:
        //Console.WriteLine();
        //Console.WriteLine(totalCount);
        //Console.WriteLine(finalLast);
        //Console.WriteLine();
        
        //result display:
        Console.WriteLine();
        Console.Write("result: ");
        for (int j = totalCount; j > 0 ; j--)
        {
            Console.Write("{0}, ", finalLast - j);
        }
        Console.WriteLine(finalLast);
    }
}