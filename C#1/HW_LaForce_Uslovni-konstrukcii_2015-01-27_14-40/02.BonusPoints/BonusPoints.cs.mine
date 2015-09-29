using System;
using System.Globalization;
using System.Threading;


class BonusPoints
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Bonus Score
*Write a program that applies bonus score to given score in the range `[1…9]` 
by the following rules:
	*If the score is between `1` and `3`, the program multiplies it by 
`10`.
	*If the score is between `4` and `6`, the program multiplies it by 
`100`.
	*If the score is between `7` and `9`, the program multiplies it by 
1000`.
	*If the score is `0` or more than `9`, the program prints `“invalid 
score”`
_Examples:_
| score | result        |
|-------|---------------|
| 2     | 20            |
| 4     | 400           |
| 9     | 9000          |
| -1    | invalid score |
| 10    | invalid score |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert score, please.");
        double score = double.Parse(Console.ReadLine());

        int bonus = 0;

        if (score >= 0 && score <= 3)
        {
            bonus = 10;
        }
        else if (score > 3 && score <= 6)
        {
            bonus = 100;
        }
        else if (score > 6 && score <= 9)
        {
            bonus = 1000;
        }


        if (bonus != 0)
        {
            Console.WriteLine("| {0,-8}| {1,-16}|", "score", "reult");
            Console.WriteLine("| {0,-8}| {1,-16}|", score, score * bonus);
        }
        else
        {
            Console.WriteLine("| {0,-8}| {1,-16}|", "score", "reult");
            Console.WriteLine("| {0,-8}| {1,-16}|", score, "invalid score");
        }

    }
}
