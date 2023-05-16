using System;

//Problem 13.* Comparing Floats

//    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
//floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

namespace FloatComparison
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            //Setting the givven value of esp
            double eps = 0.000001;
            
            //Getting the values to compare:
            //(it breaks if i insert the numbers with the comma as fraction separator)
            //console selection section beggins:
            Console.WriteLine("Plese insert fitrst number (a) to compare, use comma as separator plese:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Plese insert second number (b) to compare, use comma as separator plese:");
            double b = double.Parse(Console.ReadLine());
            //console selection section ends.

            //If it breaks uncomment the fowolling and comment the console selection section please:
            //double a = 1.234567;
            //double b = 1.234568;

            //Displays esp, a and b:
            Console.WriteLine("eps is: {0}, \na is: {1} \nb is: {2}", eps, a, b);

            //Compareing the values:
            bool areEqual = Math.Abs((a - b)) < eps;

            //Display the result:
            Console.WriteLine("a equals b? : {0}. ", areEqual);
        }
    }
}
