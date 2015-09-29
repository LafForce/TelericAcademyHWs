using System;

class SubStrInTxt
{
    static void Main()
    {
        Console.WriteLine(@"Problem 4. Sub-string in text
Write a program that finds how many times a sub-string is contained in a 
given text (perform case insensitive search).
Example:
The target sub-string is in
The text is as follows: We are living in an yellow submarine. We don't 
have anything else. inside the submarine is very tight. So we are drinking
all the day. We will move out of it in 5 days.
The result is: 9
============================================================================
Solution:");
        Console.WriteLine("Enter substring to search for, please");
        string searchFor = Console.ReadLine();

        //automat:
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        
        ////or manual:
        //Console.WriteLine("Enter text, please.");
        //string text = Console.ReadLine();

        int count = 0;

        for (int i = 0; i <= text.Length - searchFor.Length; i++)
        {
            if (text.Substring(i, searchFor.Length) == searchFor)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}