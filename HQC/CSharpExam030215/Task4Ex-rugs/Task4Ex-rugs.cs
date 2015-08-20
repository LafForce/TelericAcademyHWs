using System;

internal class Task4Ex_rugs
{
    static void Main()
    {
        int dimension = Int16.Parse(Console.ReadLine());

        short numberOfX = Int16.Parse(Console.ReadLine());

        char dot = '.';
        char letterX = 'X';
        char slash = '/';
        char backslash = '\\';
        char hashtaGCahr = '#';

        int firstXzeroLine = dimension - (numberOfX / 2) - 1;
        int secondXzeroLine = dimension + (numberOfX / 2) + 1;

        for (int i = 0; i < 2 * dimension + 1; i++)
        {
            for (int j = 0; j < (2 * dimension) + 1; j++)
            {
                if (i < 2 * dimension - numberOfX)
                {

                }
                else if (i == 0)
                {
                    if (j < firstXzeroLine || j > secondXzeroLine)
                    {
                        Console.Write(dot);
                    }
                    else if (j == firstXzeroLine || j == secondXzeroLine)
                    {
                        Console.Write(letterX);
                    }
                    else if (j > firstXzeroLine || j < secondXzeroLine)
                    {
                        Console.Write(hashtaGCahr);
                    }
                }
            }
            Console.WriteLine();
        }

    }

}