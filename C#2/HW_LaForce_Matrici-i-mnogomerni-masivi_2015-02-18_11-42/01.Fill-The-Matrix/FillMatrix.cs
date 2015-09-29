using System;

class fillMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine(@" Problem 1. Fill the matrix
Write a program that fills and prints a matrix of size (n, n)
============================================================================
Solution:

");

        Console.WriteLine("Enter the size n of the matrix please");
        int n = int.Parse(Console.ReadLine().ToString());

        int[,] maTrix = new int[n, n];
        
        //Case a
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                maTrix[i, j] = j * n + 1 + i;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Case a) : ");
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-3}", maTrix[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //Case b
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j % 2 == 0)
                {
                    maTrix[i, j] = j * n + 1 + i;
                }
                else
                {
                    maTrix[i, j] = (j + 1) * n - i;

                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Case b) : ");
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-3}", maTrix[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //case c

            int number = 1;
            int currentRow;

            for (int row = n - 1; row >= 0; row--)
            {
                currentRow = row;
                for (int col = 0; col < n - row; col++)
                {
                    maTrix[currentRow++, col] = number++;
                }
            }

            number = n * n;

            for (int row = 0; row < n - 1; row++)
            {
                currentRow = row;
                for (int col = n - 1; currentRow >= 0; col--)
                {
                    maTrix[currentRow--, col] = number--;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Case c) : ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-3}", maTrix[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }


            ////Case d
            //int[] rowDRUL = new int[] { 1, 0, -1, 0 };
            //int[] colDRUL = new int[] { 0, 1, 0, -1 };
            //int direction = 0;
            //number = 1;
            //int r = 0;
            //int c = 0;
            //int nextRow;
            //int nextCol;

            //while (number <= n * n)
            //{
            //    maTrix[r, c] = number++;
            //    nextRow = r + rowDRUL[direction];
            //    nextCol = c + colDRUL[direction];

            //    if ((nextRow < 0 || nextRow >= n) ||
            //        (nextCol < 0 || nextCol >= n) ||
            //        maTrix[nextRow, nextCol] != 0)
            //    {
            //        direction = (direction + 1) % 4;
            //    }

            //    r -= rowDRUL[direction];
            //    c += colDRUL[direction];
               
            //}

            //Console.WriteLine();
            //Console.WriteLine("Case d) : ");
            //Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0,-3}", maTrix[i, j]);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
       
        }
    }
