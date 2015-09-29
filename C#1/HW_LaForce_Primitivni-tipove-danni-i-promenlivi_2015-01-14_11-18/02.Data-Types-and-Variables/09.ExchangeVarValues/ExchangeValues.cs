<<<<<<< .mine
﻿using System;

//Problem 9. Exchange Variable Values

//    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their 
//values by using some programming logic.
//    Print the variable values before and after the exchange.

namespace ExchangeVarValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            //Declare the given for the problemq and display the initiated values of variables:
            int a = 5;
            int b = 10;
            Console.WriteLine("Variable \"a\" has assigned value of: {0} , and the value of \"b\" is: {1}", a, b);
            //switch:
            int holder = a;
            a = b;
            b = holder;
            //Check if the switch is done properly:
            Console.WriteLine("Variable \"a\" has assigned value of: {0} , and the value of \"b\" is: {1}", a, b);
        }
    }
}
||||||| .r0
=======
﻿using System;

//Problem 9. Exchange Variable Values

//    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their 
//values by using some programming logic.
//    Print the variable values before and after the exchange.

namespace ExchangeVarValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            //Declare the given for the problemq and display the initiated values of variables:
            int a = 5;
            int b = 10;
            Console.WriteLine("Variable \"a\" has assigned value of: {0} , and the value of \"b\" is: {1}", a, b);
            //switch:
            int holder = a;
            a = b;
            b = holder;
            //Check if the switch is done properly:
            Console.WriteLine("Variable \"a\" has assigned value of: {0} , and the value of \"b\" is: {1}", a, b);
        }
    }
}
>>>>>>> .r6
