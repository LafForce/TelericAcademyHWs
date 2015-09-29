<<<<<<< .mine
﻿using System;

//Problem 11. Bank Account Data

//    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//    Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//and descriptive names.

namespace BankAcc
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            //Declare:
            string holderFirstName = "John";
            string holderMiddleName = "Ivanov";
            string holderLastName = "Chukov";
            decimal balanceAmount = 100123456.9843m;
            string nameOfBank = "Crazyly Generous Bank International Inc.";
            string codeIBAN = "BGSFNH123123123123GH";
            ulong numberCardOne = 123456789011;
            ulong numberCardTwo = 123456789012;
            ulong numberCardThree = 123456789013;
            
            //Check:
            Console.WriteLine("Holder's first name:_______" + holderFirstName);
            Console.WriteLine("Holder's second name:______" + holderMiddleName);
            Console.WriteLine("Holder's family name:______" + holderLastName);
            Console.WriteLine("Holder's account balance:__" + balanceAmount);
            Console.WriteLine("Bank's name:_______________" + nameOfBank);
            Console.WriteLine("Account's IBAN number:_____" + codeIBAN);
            Console.WriteLine("Credit card number 1:______" + numberCardOne);
            Console.WriteLine("Credit card number 2:______" + numberCardTwo);
            Console.WriteLine("Credit card number 3:______" + numberCardThree);
            Console.WriteLine();
        
        }
    }
}
||||||| .r0
=======
﻿using System;

//Problem 11. Bank Account Data

//    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//    Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//and descriptive names.

namespace BankAcc
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            //Declare:
            string holderFirstName = "John";
            string holderMiddleName = "Ivanov";
            string holderLastName = "Chukov";
            decimal balanceAmount = 100123456.9843m;
            string nameOfBank = "Crazyly Generous Bank International Inc.";
            string codeIBAN = "BGSFNH123123123123GH";
            ulong numberCardOne = 123456789011;
            ulong numberCardTwo = 123456789012;
            ulong numberCardThree = 123456789013;
            
            //Check:
            Console.WriteLine("Holder's first name:_______" + holderFirstName);
            Console.WriteLine("Holder's second name:______" + holderMiddleName);
            Console.WriteLine("Holder's family name:______" + holderLastName);
            Console.WriteLine("Holder's account balance:__" + balanceAmount);
            Console.WriteLine("Bank's name:_______________" + nameOfBank);
            Console.WriteLine("Account's IBAN number:_____" + codeIBAN);
            Console.WriteLine("Credit card number 1:______" + numberCardOne);
            Console.WriteLine("Credit card number 2:______" + numberCardTwo);
            Console.WriteLine("Credit card number 3:______" + numberCardThree);
            Console.WriteLine();
        
        }
    }
}
>>>>>>> .r6
