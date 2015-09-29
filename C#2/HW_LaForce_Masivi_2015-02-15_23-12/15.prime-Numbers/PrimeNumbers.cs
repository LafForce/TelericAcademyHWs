using System;

class QuickSort
{
    static void Main()
    {
        System.Console.WriteLine(@"Problem 15. Prime numbers
Write a program that finds all prime numbers in the range [1...10 000 000].
Use the Sieve of Eratosthenes algorithm.
============================================================================
Solution:");

        //create the ma3x:
        Console.WriteLine("Enter the upper limit of the range:");
        long maxN = long.Parse(Console.ReadLine().ToString());
        bool[] theSieve = new bool[maxN];

        //weed out the non primes by finding mutiples 
        for (int j = 2; j < maxN; j++)
        {
            if (!theSieve[j])
            {
                for (long p = 2; (p * j) < maxN; p++)
                {
                    theSieve[p * j] = true;
                }
            }
        }

        //display:
        Console.WriteLine();
        for (int k = 2; k < theSieve.Length; k++)
        {
            if (!theSieve[k])
            { 
                Console.Write("{0}; ", k);
            }
        }
    }
}