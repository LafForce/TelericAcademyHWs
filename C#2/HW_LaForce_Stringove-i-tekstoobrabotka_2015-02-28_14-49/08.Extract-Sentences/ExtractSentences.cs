using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
class  ExtractSentences
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem 8. Extract sentences
Write a program that extracts from a given text all sentences containing 
given word.
Example:
The word is: in
The text is: We are living in a yellow submarine. We don't have anything 
else. Inside the submarine is very tight. So we are drinking all the day. 
We will move out of it in 5 days.
The expected result is: We are living in a yellow submarine. We will move 
out of it in 5 days.
Consider that the sentences are separated by . and the words – by 
non-letter symbols.
============================================================================
Solution:");
        string text = @"We are living in a yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day. 
We will move out of it in 5 days.";

        StringBuilder result = new StringBuilder();

        string[] sentence = text.Split('.');

        for (int i = 0; i < sentence.Length; i++)
        {
            for (int j = 0; j < sentence[i].Length - 3; j++)
			{
                if (sentence[i].Substring(j, 4) == " in ")
                {
                    result.Append(sentence[i] + '.');
                }
			} 
        }
        Console.WriteLine(result);
    }
}
