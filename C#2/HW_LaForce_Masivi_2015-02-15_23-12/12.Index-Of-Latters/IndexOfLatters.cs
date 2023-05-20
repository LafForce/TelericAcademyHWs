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

        Console.WriteLine("Display of the alphabet array");
        Console.Write("Index:  ");
        for (int i = 0; i < alfabethCapitals.Length; i++)
        {
            Console.Write("{0,-3}|", i);
        }
        Console.WriteLine();
        Console.Write("Letter: ");
        for (int i = 0; i < alfabethCapitals.Length; i++)
        {
            Console.Write("{0,-3}|", alfabethCapitals[i] = (char)('A' + i));
        }
        Console.WriteLine();

        //get the word:
        Console.WriteLine("Insert a word on the fowolling row, using CAPITAL letters(A-Z), please.");
        char[] word = Console.ReadLine().ToUpper().ToCharArray();
        
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
