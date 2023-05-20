using System;


class PermutationOfSet
{
    static void Given()
    {
        Console.WriteLine(@"Problem 19.* Permutations of set
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
        caseOne.SetPermutation(arrayPermuted);
    }
       
    //the different sets:
    public void SetPermutation(int[] ArrayOfOrderedNumbersToBePermuted)
    {
        Permutation(ArrayOfOrderedNumbersToBePermuted, 0, ArrayOfOrderedNumbersToBePermuted.Length - 1);
    }

    //the action:
    private void Permutation(int[] arrayOfOrderedNumbers, int startIndex, int endIndex)
    {
        int currentIndex;
        if (startIndex == endIndex)
        {
            string result = String.Join(", ", arrayOfOrderedNumbers);
            Console.WriteLine(result);
        }
        else
            for (currentIndex = startIndex; currentIndex <= endIndex; currentIndex++)
            {
                Swap(ref arrayOfOrderedNumbers[startIndex], ref arrayOfOrderedNumbers[currentIndex]);
                Permutation(arrayOfOrderedNumbers, startIndex + 1, endIndex);
                Swap(ref arrayOfOrderedNumbers[startIndex], ref arrayOfOrderedNumbers[currentIndex]);
            }
    }

    //the swap:
    private void Swap(ref int currentStartIndex, ref int currentEndIndex)
    {
        if (currentStartIndex == currentEndIndex) return;
        currentStartIndex ^= currentEndIndex;
        currentEndIndex ^= currentStartIndex;
        currentStartIndex ^= currentEndIndex;
    }

}
