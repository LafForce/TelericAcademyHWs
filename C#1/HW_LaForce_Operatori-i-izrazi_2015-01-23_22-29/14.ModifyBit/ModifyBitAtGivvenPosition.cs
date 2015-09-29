<<<<<<< .mine
﻿using System;

//Problem 14. Modify a Bit at Given Position

//    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//    Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//    the value v at the position p from the binary representation of n while preserving all other bits in n.

//Examples:
//n 	    binary representation of n 	p 	v 	binary result 	    result
//5 	    00000000 00000101 	        2 	0 	00000000 00000001 	1
//0 	    00000000 00000000 	        9 	1 	00000010 00000000 	512
//15 	    00000000 00001111 	        1 	1 	00000000 00001111 	15
//5343      00010100 11011111 	        7 	0 	00010100 01011111 	5215
//62241 	11110011 00100001 	        11 	0 	11110011 00100001 	62241

class ModifyBitAtGivvenPosition
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold 
the value v at the position p from the binary representation of n while 
preserving all other bits in n.
Examples:
n 	    binary representa 	p 	v 	binary result 	    result
5 	    00000000 00000101   2 	0 	00000000 00000001 	1
0 	    00000000 00000000   9 	1 	00000010 00000000 	512
15 	    00000000 00001111   1 	1 	00000000 00001111 	15
5343        00010100 11011111   7 	0 	00010100 01011111 	5215
62241 	    11110011 00100001   11 	0 	11110011 00100001 	62241
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert number \"n\" to be modified, please");
        int numberN = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));


        Console.WriteLine("Insert position \"p\", please");
        int positionP = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert bit value \"v\" (0 or 1), please");
        int bitValue = int.Parse(Console.ReadLine());

        //if bit value is 0 or 1:
        if (bitValue == 0 | bitValue == 1)
        {
            //change if bit value is 0 and puting it on position p:
            if (bitValue == 0)
            {
                int mask = ~(1 << positionP);
                //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));

                int newNumber = (numberN & mask);
                //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(16, '0'));

                Console.WriteLine(newNumber);
            }

            //if bit value is 1 set it on position p:
            else
            {
                int mask = (1 << positionP);
                //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));

                int newNumber = (numberN | mask);
                //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(16, '0'));

                Console.WriteLine(newNumber);
            }
        }
       
        //if bit value is not 0 or 1:
        else
        {
            Console.WriteLine("the bit value is nor 0 nor 1");
        }
    }
}


||||||| .r0
=======
﻿using System;

//Problem 14. Modify a Bit at Given Position

//    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//    Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//    the value v at the position p from the binary representation of n while preserving all other bits in n.

//Examples:
//n 	    binary representation of n 	p 	v 	binary result 	    result
//5 	    00000000 00000101 	        2 	0 	00000000 00000001 	1
//0 	    00000000 00000000 	        9 	1 	00000010 00000000 	512
//15 	    00000000 00001111 	        1 	1 	00000000 00001111 	15
//5343      00010100 11011111 	        7 	0 	00010100 01011111 	5215
//62241 	11110011 00100001 	        11 	0 	11110011 00100001 	62241

class ModifyBitAtGivvenPosition
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold 
the value v at the position p from the binary representation of n while 
preserving all other bits in n.
Examples:
n 	    binary representa 	p 	v 	binary result 	    result
5 	    00000000 00000101   2 	0 	00000000 00000001 	1
0 	    00000000 00000000   9 	1 	00000010 00000000 	512
15 	    00000000 00001111   1 	1 	00000000 00001111 	15
5343        00010100 11011111   7 	0 	00010100 01011111 	5215
62241 	    11110011 00100001   11 	0 	11110011 00100001 	62241
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert number \"n\" to be modified, please");
        int numberN = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));


        Console.WriteLine("Insert position \"p\", please");
        int positionP = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert bit value \"v\" (0 or 1), please");
        int bitValue = int.Parse(Console.ReadLine());

        //if bit value is 0 or 1:
        if (bitValue == 0 | bitValue == 1)
        {
            //change if bit value is 0 and puting it on position p:
            if (bitValue == 0)
            {
                int mask = ~(1 << positionP);
                //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));

                int newNumber = (numberN & mask);
                //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(16, '0'));

                Console.WriteLine(newNumber);
            }

            //if bit value is 1 set it on position p:
            else
            {
                int mask = (1 << positionP);
                //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));

                int newNumber = (numberN | mask);
                //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(16, '0'));

                Console.WriteLine(newNumber);
            }
        }
       
        //if bit value is not 0 or 1:
        else
        {
            Console.WriteLine("the bit value is nor 0 nor 1");
        }
    }
}


>>>>>>> .r6
