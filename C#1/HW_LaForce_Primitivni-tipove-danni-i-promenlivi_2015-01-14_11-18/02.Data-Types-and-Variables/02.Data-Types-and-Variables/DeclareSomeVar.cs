using System;


//Problem 1. Declare Variables

//    Declare five variables choosing for each of them the most appropriate of the types byte, 
//sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

//Submit the source code of your Visual Studio project as part of your homework submission.

namespace DataTypeAndVariables
{
    class DeclareSomeVar
    {
        static void Main()
        {
            ushort aUshort = 52130;
            sbyte aSbyte = -115;
            int aInt = 4825932;
            byte aByte = 97;
            short aShort = -10000;

            Console.WriteLine("variable named : aUshort of type : " + aUshort.GetType() + " with value {0}", aUshort);
            Console.WriteLine("variable named : aSbyte of type : " + aSbyte.GetType() + " with value {0}", aSbyte);
            Console.WriteLine("variable named : aInt of type : " + aInt.GetType() + " with value {0}", aInt);
            Console.WriteLine("variable named : aByte of type : " + aByte.GetType() + " with value {0}", aByte);
            Console.WriteLine("variable named : aShort of type : " + aShort.GetType() + " with value {0}", aShort);
        }
    }
}
