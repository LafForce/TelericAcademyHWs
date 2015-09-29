using System;
using System.Linq;

class SolveTasks
{
    // all tasks in the methods below:
    static void Main()
    {
        Given();

        InterFaceBace();
    }
        
    static void InterFaceBace()
    {
        
        Console.WriteLine("This is a selection interface!");
        Console.WriteLine(@"select one of the options by typing it on the console:
        1 for Reverse the digits of a number
        2 for avreage of a sequence
        3 for linear equatinon
        ");
        try
        {
            int selection = int.Parse(Console.ReadLine().ToString());
            if (selection == 1)
            {
                Reverse();
            }
            else if (selection == 2)
            {
                Average();
            }
            else if (selection== 3)
            {
                Linear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(@"WUT? a mistake I guess, :
TRY AGAYN:
");
            
            InterFaceBace();
            }
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine(@"You have not inserted a valid option, little mokey you!!:)
TRY AGAYN:
");
            
            InterFaceBace();
        }

    }
    static void Given()
{
         Console.WriteLine(@"Problem 13. Solve tasks
Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
============================================================================
Solution:");
        Console.WriteLine();
    }
    static void Reverse()
    {
        Console.Clear();
        Console.WriteLine("Insert number whose digits you want reversed, please.");
        string num = Console.ReadLine();
        char[] numChars = num.ToCharArray();
        Array.Reverse(numChars);
        for (int i = 0; i < numChars.Length; i++)
        {
            Console.Write(numChars[i]);
        }
        Console.WriteLine();
    }
    static void Average()
    {
        Console.Clear();

        Console.WriteLine(@"Insert sequence to see its average...");
        Console.Write("On this row, coma separated, please: ");

        int[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine();
        double average = (double)sum / (numbers.Length);
        
        Console.WriteLine(average);
        Console.WriteLine();
    }
    static void Linear()
        {
            Console.Clear();
            Console.WriteLine("This solves a linear equation (a * x + b = 0)!");
            Console.WriteLine();
            Console.WriteLine("Insert coeficient a, please. ");
            double numberA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert coeficient b, please. ");
            double numberB = double.Parse(Console.ReadLine());

            double result = -numberB / numberA;

            Console.WriteLine();
            Console.WriteLine("x equals {0}", result);
            Console.WriteLine();

        }

}