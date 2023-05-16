using System;

//Problem 4. Unicode Character

//    Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
//using the \u00XX syntax, and then print it.

//Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

namespace UnicodeCharacter
{
    class UnicodeChar
    {
        static void Main(string[] args)
        {
            //declare:
            char myVar;

            //assign value 2A is equivalent to the decimal number 42 in Hex:
            myVar = '\u002a';


            //I guess alternatively in c# we may do the following with the same result:
            //char myVar = '\u002A';

            //Check if this is the symbol we look for:
            Console.WriteLine(myVar);
        }
    }
}
