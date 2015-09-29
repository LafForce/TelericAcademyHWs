using System;
class CopCharArr
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem 3. Compare char arrays
*Write a program that compares two `char` arrays lexicographically 
(letter by letter).
============================================================================
Solution:");

        Console.WriteLine("Insert first charr array on the fowolling row, please.");
        char[] first = Console.ReadLine().ToCharArray();
        Console.WriteLine("Insert second charr array on the fowolling row, please.");
        char[] second = Console.ReadLine().ToCharArray();

        // the check:
        bool areEQ = true;

        //if identical index's lengths:
        if (first.Length == second.Length)
        {
            //if identical member values:
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    areEQ = false;
                    break;
                }
            }

        }
        else
        {
            areEQ = false;
        }

        //display:
        Console.WriteLine("The two arrays are: {0}", areEQ ? "\"Equal\"" : "\"Not equal\"");
        Console.WriteLine();
        
        //for (int i = 0; i < first.Length; i++)
        //{
        //    Console.Write("{0}; {1}", first[i], second[i]);
        //}
        //Console.WriteLine();
    }
}