using System;

class SayHello
{
    static void Main()
    {
        Console.WriteLine(@"Problem 1. Say Hello
Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:
input	output
Peter	Hello, Peter!		
============================================================================
Solution:");
        Console.WriteLine();
        
        SayHi();

        Console.WriteLine();
    }
    static void SayHi()
    {
        Console.WriteLine("What's you name, friend?");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}", name);
        Console.WriteLine();


    }

    static void Tester()
    {
        

    }
}
