using System;

//Problem 12. Null Values Arithmetic

//    Create a program that assigns null values to an integer and to a double variable.
//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.

namespace _12.NullValuesarithmetics
{
    class NullValues
    {
        static void Main(string[] args)
        {
            //Create a program that assigns null values to an integer and to a double variable:
            int? i = null;
            double? d = null;

            //Try to print these variables at the console:
            Console.WriteLine("integer \"i\" has such:!{0}! value.", i);
            Console.WriteLine("double \"d\" has such:!{0}! value.", d);

            //Try to add some number or the null literal to these variables and print the result.
           
           
            Console.WriteLine("after the opperation integer \"i\" has such:!{0}! value.", (i + 1));
            Console.WriteLine("after the opperation double \"d\" has such:!{0}! value.", (d + null));

        }
    }
}
