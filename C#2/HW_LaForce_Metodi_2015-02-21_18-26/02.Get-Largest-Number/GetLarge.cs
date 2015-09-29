using System;

class GetLarge
{
    static void Main()
    {
        Console.WriteLine(@"Problem 2. Get largest number
Write a method GetMax() with two parameters that returns the larger of 
two integers.
Write a program that reads 3 integers from the console and prints the 
largest of them using the method GetMax().
============================================================================
Solution:");

        Console.WriteLine("Insert first number, please.");
        int numberFirst = int.Parse(Console.ReadLine().ToString());

        Console.WriteLine("Insert second number, please.");
        int numberSecond = int.Parse(Console.ReadLine().ToString());

        Console.WriteLine("Insert third number, please.");
        int numberThird = int.Parse(Console.ReadLine().ToString());

        int firstCompared = GetMax(numberFirst, numberSecond);
        int secondCompared = GetMax(numberFirst, numberThird);

        Console.WriteLine();
        Console.Write("The biggest of the tree is: ");
        Console.WriteLine(GetMax(firstCompared, secondCompared));


        Console.WriteLine();
    }
    static int GetMax(int a, int b)
    {
        if (a == b)
        {
            return a;
        }
        else if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}