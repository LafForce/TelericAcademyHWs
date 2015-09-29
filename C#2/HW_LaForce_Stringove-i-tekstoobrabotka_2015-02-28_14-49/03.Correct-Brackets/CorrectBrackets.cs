using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine(@"Problem 3. Correct brackets
Write a program to check if in a given expression the brackets are put 
correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression:
)(a+b)).
============================================================================
Solution:");

        //Console.Write("Enter an expression: ");
        //string expression = Console.ReadLine();

        //Aytomatic input:
        string expression = ")(a+b)(.";


        Console.WriteLine(AreCorrect(expression) ? "CORRECT" : "INCORRECT");
    }

    private static bool AreCorrect(string expression)
    {
        int bracketCount = 0;

        foreach (var letter in expression)
        {
            if (letter == '(')
                ++bracketCount;
            else if (letter == ')')
                --bracketCount;

            if (bracketCount < 0)
                return false;
        }

        return bracketCount == 0;
    }
}
