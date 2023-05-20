using System;
using System.Collections.Generic;
using System.Text;


class Merge
{
    static void Main(string[] args)
    {
        //the given:
        Given();

        //the input:
        // imputed unsorted array:
        int[] numbers = { 16, 2, 5, 59, 6, 10, 345, 13, 14, 1, 12, 178, 20, 125, 3880, 33, 334, 33, 23, 50, 202, 2220, 2122, 30 };

        ////manual imput?:
        //Console.WriteLine("Insert unsorted array on the fowolling row, please.");
        
        ////int[] numbers = Console.ReadLine().Split(new char[] { ' ', '.', '\t', ',' }
        ////    , StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        ////another way of getting numbers(also negative) from a row sepparated by any nonnumerical char
        //char[] seque = Console.ReadLine().ToCharArray();
        //StringBuilder nextNumber = new StringBuilder();
        //List<int> numbersList = new List<int>();    
        //foreach (char ch in seque)
        //{
        //    if (char.IsNumber(ch) || ch == '-')
        //    {
        //        nextNumber.Append(ch);
        //    }
        //    else
        //    {
        //        if(int.TryParse(nextNumber.ToString(), out int intnum))
        //        numbersList.Add(intnum);
        //        nextNumber.Clear();
        //    }
        //}
        //int[] numbers = numbersList.ToArray();  

        //the output:
        Console.WriteLine("Sorted array:");
        MergeSort(numbers, 0, numbers.Length - 1);
        string result = String.Join(", ", numbers);
        Console.WriteLine(result);
        Console.WriteLine();

    }


    //sorting of unsorted array:
    static public void MergeSort(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSort(numbers, left, mid);
            MergeSort(numbers, (mid + 1), right);

            DoMerge(numbers, left, (mid + 1), right);
        }
    }


    //merge of sorted arrays:
    static public void DoMerge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[numbers.Length];
        int i, left_end, num_elements, tmp_pos;

        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);

        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmp_pos++] = numbers[left++];
            else
                temp[tmp_pos++] = numbers[mid++];
        }

        while (left <= left_end)
            temp[tmp_pos++] = numbers[left++];

        while (mid <= right)
            temp[tmp_pos++] = numbers[mid++];

        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static void Given()
    {
        System.Console.WriteLine(@"Problem 13.* Merge sort
Write a program that sorts an array of integers using the Merge sort 
algorithm (find it in Wikipedia).
============================================================================
Solution:");
        Console.WriteLine();
    }
}