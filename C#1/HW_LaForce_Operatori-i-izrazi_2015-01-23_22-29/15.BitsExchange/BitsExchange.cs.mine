using System;
using System.Text;

//Problem 15.* Bits Exchange

//    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

//Examples:
//n 	        binary representation of n 	            binary result 	                        result
//1140867093 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
//255406592 	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
//4294901775 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
//5351 	        00000000 00000000 00010100 11100111 	00000100 00000000 00010100 11000111 	67114183
//2369124121 	10001101 00110101 11110111 00011001 	10001011 00110101 11110111 00101001 	2335569705

class bitsExchange
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of 
given 32-bit unsigned integer.

----------------------------------------------------------------------------
Solution:

");
        //Get a number:
        Console.WriteLine("Insert number \"n\" to be modified, please");
        long numberN = long.Parse(Console.ReadLine());

        //to string:
        string strNum = Convert.ToString((numberN), 2).PadLeft(32, '0');

        char[] arrOfChar = strNum.ToCharArray();

        //the actual "bit" swap:
        for (int i = 5; i <= 7; i++)
        {
            char swap = arrOfChar[i];
            arrOfChar[i] = arrOfChar[21 + i];
            arrOfChar[21 + i] = swap;
        }

        //returning the value to int format
        string newString = null;
        for (int index = 0; index <= 31; index++)
        {
            newString += arrOfChar[index];
        }
        long result = Convert.ToInt64(newString, 2);

        //displays results:
        Console.WriteLine("{0, -15} : {1, -35}", "Number", numberN);
        Console.WriteLine("{0, -15} : {1, -35}", "Binary number", strNum);
        Console.WriteLine("{0, -15} : {1, -35}", "Binary result", newString);
        Console.WriteLine("{0, -15} : {1, -35}", "Result", result);
    }
}
