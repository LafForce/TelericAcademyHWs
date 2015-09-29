using System;
using System.Collections.Generic;

class MaxSequ
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(@"Problem 4. Maximal sequence 
*Write a program that finds the **maximal sequence** of equal elements in 
an array.
_Example:_
|              input              | result  |
|---------------------------------|---------|
| 2, 1, 1, 2, 3, 3, **2, 2, 2**, 1 | 2, 2, 2 |
============================================================================
Solution:");
        //get data:
        Console.WriteLine("Insert secquence of simple digits on the fowolling row, please.");
        char[] seque = Console.ReadLine().ToCharArray();
                        
        List<int> numberSeq = new List<int>();
        
        for (int i = 0; i < seque.Length; i++)
			{
                
                    if (Char.IsNumber(seque[i]))
                    {
                        numberSeq.Add((int)Char.GetNumericValue(seque[i]));
                    }
			}
          
        //chk:
        int rememberer;
        short counter = 0;
        
        int totalCount = 0;
        int champ = 0;

        for (int k = 0; k < numberSeq.Count; k++)
        {
                rememberer = numberSeq[k];
 
            if (k > 0 && numberSeq[k - 1] == rememberer)

                {
                    ++counter;
                    if (totalCount < counter)
                    {
                        totalCount = counter;
                        champ = rememberer;
                    }
                }

                else
                {
                    counter = 0;
                }
         }

        //display:
        Console.WriteLine( );
        for (int j = 0; j <= totalCount; j++)
        {

            if (j <= totalCount - 1)
            {
                Console.Write("{0}, ", champ);
            }

            else
            {
                Console.WriteLine(champ);
            }
        }
        Console.WriteLine();
    }
}