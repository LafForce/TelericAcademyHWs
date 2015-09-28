using System;


//Problem 14.* Print the ASCII Table

//    Find online more information about ASCII (American Standard Code for Information Interchange) and write a 
//program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

//Note: You may need to use for-loops (learn in Internet how).

namespace PrintASCIITable
{
    class PrintASCII
    {
        static void Main()
        {
            //To account for the speciality of simbols number 0-32 I add for-loop:
            for (int nuberOfSymbol = 0; nuberOfSymbol < 33; nuberOfSymbol++)
            {
                Console.Write("Number {0} is \"special\"; ", nuberOfSymbol);
            }

            //for the rest of the symbols with numbers 33 - 255 there is another one:
            for (int nuberOfSymbol = 33; nuberOfSymbol <= 255; nuberOfSymbol++)
            {
                Console.Write("Number {0} is {1}; ", nuberOfSymbol, (char)nuberOfSymbol);
            }
        }
    }
}