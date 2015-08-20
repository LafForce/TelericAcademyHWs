using System;
using System.Linq;

class Problem1ABandC
{
    static void Main()
    {
        int[] abc = new int[3];
        abc[0] = Int32.Parse(Console.ReadLine());
        abc[1] = Int32.Parse(Console.ReadLine());
        abc[2] = Int32.Parse(Console.ReadLine());

        int maxNum = Int32.MinValue;
        int minNum = Int32.MaxValue;

        for (int i = 0; i < 3; i++)
        {
            if (maxNum < abc[i])
            {
                maxNum = abc[i];
            }
            if (minNum > abc[i])
            {
                minNum = abc[i];
            }
        }

        Console.WriteLine(maxNum);
        Console.WriteLine(minNum);
        
        double aritmeticMean = (abc.Average());
        Console.WriteLine("{0:F3} ", aritmeticMean);
    }
}

