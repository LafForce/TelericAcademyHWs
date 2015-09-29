using System;


class PermutationOfSet
{
    static void Given()
    {
        System.Console.WriteLine(@"Problem 19.* Permutations of set
Write a program that reads a number N and generates and prints all the 
permutations of the numbers [1 … N].
Example:
N	result
3	{1, 2, 3} 
{1, 3, 2} 
{2, 1, 3} 
{2, 3, 1} 
{3, 1, 2} 
{3, 2, 1}
============================================================================
Solution:");
    }

    static void Main()
    {
        //the conditions:
        Given();

        //our permutation
        PermutationOfSet caseOne = new PermutationOfSet();

        //the input:
        Console.WriteLine("Please insert number of numbers to be permuted.");
        int count = int.Parse(Console.ReadLine().ToString());

        //crating the array:
        int[] arrayPermuted = new int[count];
        for (int i = 0; i < count; i++)
        {
            arrayPermuted[i] = i + 1;
        }
        /* Calling the permute */
        caseOne.setper(arrayPermuted);
    }

    //the swap:
    private void swap(ref int a, ref int b)
    {
        if (a == b)
            return;
        a ^= b;
        b ^= a;
        a ^= b;
    }

    //the different sets:
    public void setper(int[] list)
    {
        int x = list.Length - 1;
        permutation(list, 0, x);
    }

    //the action:
    private void permutation(int[] list, int k, int m)
    {
        int i;
        if (k == m)
        {
            string result = String.Join(", ", list);
            Console.WriteLine(result);
        }
        else
            for (i = k; i <= m; i++)
            {
                swap(ref list[k], ref list[i]);
                permutation(list, k + 1, m);
                swap(ref list[k], ref list[i]);
            }
    }
}
