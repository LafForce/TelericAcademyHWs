using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FreqNum
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(@" Problem 9. Frequent number
Write a program that finds the most frequent number in an array.
Example:
input	                                result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)
============================================================================
Solution:");

            //get data:
            Console.WriteLine("Insert secquence of simple digits on the fowolling row, please.");
            char[] sequ = Console.ReadLine().ToCharArray();

            List<int> numberSequ = new List<int>();

            for (int i = 0; i < sequ.Length; i++)
            {

                if (Char.IsNumber(sequ[i]))
                {
                    numberSequ.Add((int)Char.GetNumericValue(sequ[i]));
                }
            }

            //make chk:
            int current = 0;
            int counter = 0;
            int maxCount = 0;
            int maxMember = 0;

            for (int i = 0; i < numberSequ.Count; i++)
            {
                current = numberSequ[i];
                for (int j = 0; j < numberSequ.Count; j++)
                {
                    if (current == numberSequ[j])
                    {
                        counter++;
                    }
                    if (maxCount < counter)
                    {
                        maxCount = counter;
                        maxMember = current;
                    }
                   
                }
                counter = 0;
            }

            //deliver result:
            Console.WriteLine("{0}, ({1} times)", maxMember, maxCount);
        }
    }