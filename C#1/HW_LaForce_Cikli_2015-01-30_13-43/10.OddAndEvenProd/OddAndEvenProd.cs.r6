using System;
class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem:
Odd and Even Product
*You are given `n` integers (given in a single line, separated by a space).
*Write a program that checks whether the product of the odd elements is equal
to the product of the even elements.
*Elements are counted from `1` to `n`, so the first element is odd, the second
is even, etc.
_Examples:_
| numbers           | result |
|-------------------|--------|
| 2 1 1 6 3         | yes    |
| product = 6       |        |
|                   |        |
| 3 10 4 6 5 1      | yes    |
| product = 60      |        |
|                   |        |
| 4 3 2 5 2         | no     |
| odd_product = 16  |        |
| even_product = 15 |        |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Enter the integers in line separated by a (single) space, please");
        
        //Get the string
        string redica = Console.ReadLine();
        //Get the values each at seperate string
        string[] numbers = redica.Split(' ');


        int nechetno = 1;
        int chetno = 1;
        int current = 1;
        //The loop:
        for (int i = 0; i < numbers.Length; i++)
        {
            bool isItANumberYo = int.TryParse(numbers[i], out current);
            //Console.WriteLine(current); //its a check i needed for some reason
            
            if (isItANumberYo) //if its not ... well I guess the user didn't read the instructions...
            {
                if (i % 2 != 0)
                {
                    nechetno *= current;
                }
                else
                {
                    chetno *= current;
                }
            }
        }

        Console.WriteLine("the odd product is {0}\nthe even product is {1}"
        , nechetno, chetno);
        Console.WriteLine();
        Console.WriteLine("(Are those products equal?) Result: {0}"
            , nechetno == chetno ? "Yes" : "No");
        Console.WriteLine();
    }
}