using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RandomizeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem:
 Randomize the Numbers 1…N
*Write a program that enters in integer `n` and prints the numbers `1, 2, …, 
n` in random order.
_Examples:_
| n                 | randomized numbers 1…n |
|-------------------|------------------------|
| 3                 | 2 1 3                  |
| 10                | 3 4 8 2 6 7 9 1 10 5   |
_Note: The above output is just an example. Due to randomness, your program 
most probably will produce different results. You might need to use arrays._
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Enter number n, please!");
        int n = int.Parse(Console.ReadLine());

        List<int> ordered = new List<int>();

        int swapper;

        Random rnd = new Random();
                
        for (int i = 0; i < n; i++)
        {
            do
            {
                swapper = rnd.Next(1, n + 1);
            }
            while (ordered.Contains(swapper));
            ordered.Add(swapper);
        }
        foreach (int j in ordered)
        {
            Console.Write(j + ", ");
        }
    }
}
