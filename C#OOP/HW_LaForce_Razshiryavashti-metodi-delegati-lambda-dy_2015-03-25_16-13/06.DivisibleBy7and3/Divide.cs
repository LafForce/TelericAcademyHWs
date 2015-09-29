using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SevenAndThree
{
    //        Problem 6. Divisible by 7 and 3
    //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension
    // methods and lambda expressions. Rewrite the same with LINQ.


    static void Main(string[] args)
    {
        int[] numbers = { 2, 54, 42, 34, 63, 89, 126, 189, 321, 333, 334, 335, 336 };

        var result = from number
                     in numbers
                     where number % 7 == 0 && number % 3 == 0
                     select number;

        var resultLINQ = numbers.Where(x => x % 21 == 0);
        
        Console.WriteLine("extension methods:");
        Console.WriteLine(string.Join(", ", result));
        Console.WriteLine();
        Console.WriteLine("LINQ:");
        Console.WriteLine(string.Join(", ", resultLINQ));
    }
}