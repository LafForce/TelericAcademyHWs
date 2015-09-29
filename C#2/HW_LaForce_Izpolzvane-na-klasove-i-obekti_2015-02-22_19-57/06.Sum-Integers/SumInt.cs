﻿using System;
using System.Collections.Generic;
using System.Linq;

class AllocateArray
{
    static void Main()
    {
        Console.WriteLine(@"Problem 6. Sum integers
You are given a sequence of positive integer values written into a string, 
separated by spaces.
Write a function that reads these values from given string and calculates 
their sum.
Example:
input	output
43 68 9 23 318	461
============================================================================
Solution:");
        string numbers = "43 68 9 23 318";

        Console.WriteLine();
        
        List<int> num = new List<int>(Array.ConvertAll(numbers.Split(' '), int.Parse));

        int sum = num.Sum();

            Console.WriteLine("Result: {0}", sum);
    }
}
