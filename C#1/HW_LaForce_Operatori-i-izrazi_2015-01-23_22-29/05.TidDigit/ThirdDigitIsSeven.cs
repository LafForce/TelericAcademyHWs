using System;

//### Problem 5.	Third Digit is 7?
//*	Write an expression that checks for given integer if its third digit from right-to-left is `7`.

//_Examples:_

//|    n    | Third digit 7? |
//|:-------:|:--------------:|
//| 5       | false          |
//| 701     | true           |
//| 9703    | true           |
//| 877     | false          |
//| 777877  | false          |
//| 9999799 | true           |


class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Third Digit is 7?
Write an expression that checks for given integer if its third digit from 
right-to-left is `7`.

-------------------------------------------------------------------------------
Solution:

");
        //User input information:
        Console.WriteLine("Insert number to be checked for if its third digit from right-to-left is `7`");
        
        //Getting the actual number:
        long num = long.Parse(Console.ReadLine());
        
        //The check:
        num /= 100; //make the third number last 
        bool isSeven = (num % 10 ==  7); //chek if it is 7
                                         //Console.WriteLine(isSeven);
        //Output:
        Console.WriteLine("Is the tird digit from right to left 7?");
        Console.WriteLine(isSeven ? "Yes" : "No");
    }
}

