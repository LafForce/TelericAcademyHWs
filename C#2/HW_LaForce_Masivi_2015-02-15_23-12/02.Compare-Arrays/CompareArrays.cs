using System;
using System.Linq;
class CompareArray
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem 2. Compare arrays
*Write a program that reads two `integer` arrays from the console and 
compares them element by element.
============================================================================
Solution:");

        //get values:
        Console.WriteLine("Insert first array(on one row, elements separated by a space), please.");
        string first = Console.ReadLine();
        Console.WriteLine("Insert second array(on one row, elements separated by a space), please.");
        string second = Console.ReadLine();

        int[] firstArr = Array.ConvertAll(first.Split(new char[] {' ', '.', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        int[] secondArr = Array.ConvertAll(second.Split(new char[] { ' ', '.', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

        // the check:
        bool areEQ = true; 
        //if identical index's lengths:
        if (firstArr.Length == secondArr.Length)
        {
            //if identical member values:
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
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
        Console.WriteLine("The two arrays are: {0}", areEQ ? "\"Equal\"" : "\"Not equal\"");
        Console.WriteLine();
    }
}
