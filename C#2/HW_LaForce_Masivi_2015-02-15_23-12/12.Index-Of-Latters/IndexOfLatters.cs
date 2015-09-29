using System;

class BinSearch
{
    static void Main()
    {
        System.Console.WriteLine(@"Problem 12. Index of letters
Write a program that creates an array containing all letters from the 
alphabet (A-Z). Read a word from the console and print the index of each of
its letters in the array.
============================================================================
Solution:");

        //create an array containing all letters from the alphabet (A-Z):
        char[] alfabethCapitals = new char[26];

        for (int i = 0; i < alfabethCapitals.Length; i++)
        {
            alfabethCapitals[i] = (char)('A' + i);
        }
        ////display of the alphabet array if you wish:
        //for (int i = 0; i < alfapheth.Length; i++)
        //{
        //    Console.WriteLine(alfapheth[i]);
        //}

        //get the word:
        Console.WriteLine("Insert a word on the fowolling row, using CAPITAL letters(A-Z), please.");
        char[] word = Console.ReadLine().ToCharArray();
        
        //the chk and display:
        Console.WriteLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write("{0,-3}", word[i]);
        }
        Console.WriteLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alfabethCapitals.Length; j++)
            {
                if (word[i] == alfabethCapitals[j])
                {
                    Console.Write("{0,-3}", j);
                }
            }
        }
        Console.WriteLine();
    }
}
