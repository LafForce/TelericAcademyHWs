using System;

//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

//Examples:
//n 	Prime?
//1 	false
//2 	true
//3 	true
//4 	false
//9 	false
//97 	true
//51 	false
//-3 	false
//0 	false


class PrimeNumbercheck
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Prime Number Check
Write an expression that checks if given positive integer number n (n = 100) is 
prime(i.e. it is divisible without remainder only to itself and 1)..

-------------------------------------------------------------------------------
Solution:

");
        //Declare the variables used:
        int divisorNumber = 0;
        //get the number to be checked:
        Console.WriteLine("Please insert number to be checked:");
        int n = int.Parse(Console.ReadLine());

        //or solve for n = 100:
        // int n = 100;

        //The check
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                divisorNumber++;
            }
        }
        //Boolean check and print of results:
        bool isPrime = divisorNumber == 0;
        Console.WriteLine("The number {0} is prime: {1}", n, isPrime);
    }
}
