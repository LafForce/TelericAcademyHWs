using System;
using System.Globalization;
using System.Threading;


class CheckForACard
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem:
Check for a Play Card
*Classical play cards use the following signs to designate the card face:
`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a 
string and prints “yes” if it is a valid card sign or “no” otherwise. 
Examples:
| character | Valid card sign? |
|-----------|------------------|
| 5         | yes              |
| 1         | no               |
| Q         | yes              |
| q         | no               |
| P         | no               |
| 10        | yes              |
| 500       | no               |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                
        Console.WriteLine("Insert card, please.");
        string card = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        bool isValid = false;
       for (int i = 0; i < cards.Length; i++)
        {
            if (card.Equals(cards[i], StringComparison.Ordinal))
            isValid = true;
        }
        Console.WriteLine("| {0,-20}| {1,-20}|", "character", "valid?");
        Console.WriteLine("| {0,-20}| {1,-16}|", card, isValid ? "Yes" : "No" );


    }
}