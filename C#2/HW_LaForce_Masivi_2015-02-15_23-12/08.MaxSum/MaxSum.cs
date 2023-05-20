using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(@"Problem 8. Maximal sum
Write a program that finds the sequence of maximal sum in given array.
Example:
input	                            result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
Can you do it with only one loop 
(with single scan through the elements of the array)?
============================================================================
Solution:");



        //Input data colection:
        //Console.WriteLine("Enter N, please.");
        //int n = int.Parse(Console.ReadLine());

        //int[] arr = new int[n];

        //Console.WriteLine("Enter {0} integers on sepparate rows, please.", n);

        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        //the check:
        int sum = 0;
        int totalSum = 0;
        List<int> sequ = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            
            sum += arr[i];

            if (sum <= totalSum)
            {
                sum = 0;
                sequ.Clear();
            }
            else 
            {
                totalSum = sum;
            }
            
        }
        
        //the display:
        for (int i = 0; i < sequ.Count; i++)
			{
            Console.Write(sequ[i] + " ");
        }
    }
}