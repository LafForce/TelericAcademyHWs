using System;

//### Problem 6.	Four-Digit Number
//*	Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//    *	Calculates the sum of the digits (in our example `2 + 0 + 1 + 1 = 4`).
//    *	Prints on the console the number in reversed order: `dcba` (in our example `1102`).
//    *	Puts the last digit in the first position: `dabc` (in our example `1201`).
//    *	Exchanges the second and the third digits: `acbd` (in our example `2101`).

//The number has always exactly 4 digits and cannot start with 0.

//_Examples:_

//|    n    | sum of digits | reversed | last digit in front | second and third digits exchanged |
//|:-------:|:-------------:|:--------:|:-------------------:|:---------------------------------:|
//| 2011    | 4             | 1102     | 1201                | 2101                              |
//| 3333    | 12            | 3333     | 3333                | 3333                              |
//| 9876    | 30            | 6789     | 6987                | 9786                              |


class FourDigitNum
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
TFour-Digit Number
    *	Write a program that takes as input a four-digit number in format 
abcd(e.g. 2011) and performs the following:
    *	Calculates the sum of the digits (in our example `2 + 0 + 1 + 1 = 4`).
    *	Prints on the console the number in reversed order: `dcba` (in our 
example `1102`).
    *	Puts the last digit in the first position: `dabc` (in our example 
`1201`).
    *	Exchanges the second and the third digits: `acbd` (in our example 
`2101`).

The number has always exactly 4 digits and cannot start with 0.

-------------------------------------------------------------------------------
Solution:

");
        //Getting the number:
        Console.WriteLine("Please insert a four digit number(It can't start with 0!).");
        int fourDigitNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //The next paragraph displays the number to be checked:
        string isItFourDigitNumber = fourDigitNumber.ToString();
        Console.WriteLine("The number you have inserted is:" + isItFourDigitNumber);
        Console.WriteLine();

        //The following is a check for "The number has always exactly 4 digits":
        if (isItFourDigitNumber.Length != 4)
        {
            Console.WriteLine("This is not a four digit number");
        }

        //So is it is a four digit number we proceed:
        else
        {
            //setting the separate digits in local var's:
            int firstDigit = fourDigitNumber / 1000;
            int seccondDigit = (fourDigitNumber / 100) % 10;
            int thirdDigit = (fourDigitNumber / 10) % 10;
            int digitFour = fourDigitNumber % 10;

            //Check:
            //Console.WriteLine(fourDigitNumber);
            //Console.WriteLine(firstDigit);
            //Console.WriteLine(seccondDigit);
            //Console.WriteLine(thirdDigit);
            //Console.WriteLine(digitFour);
            //Console.WriteLine();

            //The next line calculates and displays the sum of the digits:
            Console.WriteLine("The sum of the digits is: {0}", firstDigit + seccondDigit + thirdDigit + digitFour);
            Console.WriteLine();

            //The next line prints on the console the number in reversed order: `dcba`:
            Console.WriteLine("The reversed order number is: {3}{2}{1}{0} ", firstDigit, seccondDigit, thirdDigit, digitFour);
            Console.WriteLine();

            //The next line puts the last digit in the first position:
            int lastShallBeFirst = (firstDigit * 100) + (seccondDigit * 10) + thirdDigit + (digitFour * 1000);
            //check:
            Console.WriteLine("The \"last digit in front\" number is: {0} ", lastShallBeFirst);
            Console.WriteLine();

            //The next line exchanges the second and the third digits:
            int shufleTheMiddle = (firstDigit * 1000) + (seccondDigit * 10) + (thirdDigit * 100) + digitFour;
            //check:
            Console.WriteLine("The \"second and third digits exchanged\" number is: {0} ", shufleTheMiddle);
            //Console.WriteLine();
        }
    }
}
