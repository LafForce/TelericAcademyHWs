<<<<<<< .mine
﻿using System;

//Problem 2. Float or Double?

//    Which of the following values can be assigned to a variable of type float and which to a 
//variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//    Write a program to assign the numbers in variables and print them to ensure no precision is lost.

namespace FloatOrDouble
{
    class FloatDouble
    {
        static void Main()
        {
            double aDoubleVariable = 34.567839023;
            float aFloat = 12.345f;
            double bDouble = 8923.1234857;
            float cFloat = 3456.091f;

            //Check:
            Console.WriteLine("34.567839023 ?= " + aDoubleVariable);
            Console.WriteLine("12.345 ?= " + aFloat);
            Console.WriteLine("8923.1234857 ?= " + bDouble);
            Console.WriteLine("3456.091 ?= " + cFloat);
        }
    }
}
||||||| .r0
=======
﻿using System;

//Problem 2. Float or Double?

//    Which of the following values can be assigned to a variable of type float and which to a 
//variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//    Write a program to assign the numbers in variables and print them to ensure no precision is lost.

namespace FloatOrDouble
{
    class FloatDouble
    {
        static void Main()
        {
            double aDoubleVariable = 34.567839023;
            float aFloat = 12.345f;
            double bDouble = 8923.1234857;
            float cFloat = 3456.091f;

            //Check:
            Console.WriteLine("34.567839023 ?= " + aDoubleVariable);
            Console.WriteLine("12.345 ?= " + aFloat);
            Console.WriteLine("8923.1234857 ?= " + bDouble);
            Console.WriteLine("3456.091 ?= " + cFloat);
        }
    }
}
>>>>>>> .r6
