<<<<<<< .mine
﻿using System;

//Problem 12. Extract Bit from Integer

//    Write an expression that extracts from given integer n the value of given bit at index p.

//Examples:
//n 	binary representation 	p 	bit @ p
//5 	00000000 00000101 	    2 	1
//0 	00000000 00000000 	    9 	0
//15 	00000000 00001111 	    1 	1
//5343 	00010100 11011111 	    7 	1
//62241 11110011 00100001 	    11 	0

    class BitfromInteger
    {
        static void Main()
        {
            Console.WriteLine(@"Problem:
Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit 
at index p.

-------------------------------------------------------------------------------
Solution:

");
            Console.WriteLine("Which number you want checked?");
            int bitInteger = int.Parse(Console.ReadLine());

            Console.WriteLine("Which index you want checked?");
            int indexP = int.Parse(Console.ReadLine());

            //creating a mask:
            int mask = 1 << indexP;

            //Cheking the bit and returning it to first position:
            int oneOrZero = ((bitInteger & mask) >> indexP);

            //Prints result:
            Console.WriteLine("The bit on position {0} of number {1} is {2}", indexP, bitInteger, oneOrZero);
        }
    }

||||||| .r0
=======
﻿using System;

//Problem 12. Extract Bit from Integer

//    Write an expression that extracts from given integer n the value of given bit at index p.

//Examples:
//n 	binary representation 	p 	bit @ p
//5 	00000000 00000101 	    2 	1
//0 	00000000 00000000 	    9 	0
//15 	00000000 00001111 	    1 	1
//5343 	00010100 11011111 	    7 	1
//62241 11110011 00100001 	    11 	0

    class BitfromInteger
    {
        static void Main()
        {
            Console.WriteLine(@"Problem:
Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit 
at index p.

-------------------------------------------------------------------------------
Solution:

");
            Console.WriteLine("Which number you want checked?");
            int bitInteger = int.Parse(Console.ReadLine());

            Console.WriteLine("Which index you want checked?");
            int indexP = int.Parse(Console.ReadLine());

            //creating a mask:
            int mask = 1 << indexP;

            //Cheking the bit and returning it to first position:
            int oneOrZero = ((bitInteger & mask) >> indexP);

            //Prints result:
            Console.WriteLine("The bit on position {0} of number {1} is {2}", indexP, bitInteger, oneOrZero);
        }
    }

>>>>>>> .r6
