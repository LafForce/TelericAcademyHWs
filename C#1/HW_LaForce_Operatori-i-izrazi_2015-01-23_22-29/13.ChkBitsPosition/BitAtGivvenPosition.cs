<<<<<<< .mine
﻿using System;

//Problem 13. Check a Bit at Given Position

//    Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n, has value of 1.

//Examples:
//n 	binary representation of n 	p 	bit @ p == 1
//5 	00000000 00000101 	        2 	true
//0 	00000000 00000000 	        9 	false
//15 	00000000 00001111 	        1 	true
//5343 	00010100 11011111 	        7 	true
//62241 11110011 00100001 	        11 	false

    class BitAtGivvenPosition
    {
        static void Main()
        {
            Console.WriteLine(@"Problem:
Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p 
(counting from 0, starting from the right) in given integer number n, has 
value of 1.

-------------------------------------------------------------------------------
Solution:

");
            Console.WriteLine("Which number you want checked?");
            int bitInteger = int.Parse(Console.ReadLine());
            //If you want the representation in binary of the number to be cheked:
            //Console.WriteLine(Convert.ToString(bitInteger, 2).PadLeft(16, '0'));

            Console.WriteLine("Which index you want checked?");
            int indexP = int.Parse(Console.ReadLine());

            //creating a mask:
            int mask = 1 << indexP;
            //the mask in binary:
            //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));

            //Cheking the bit and storing it to local bool:
            bool oneOrZero = (((bitInteger & mask) >> indexP) == 1);

            //Prints result:
            Console.WriteLine("The bit on position {0} of number {1} is 1: {2}", indexP, bitInteger, oneOrZero);
        }
    }

||||||| .r0
=======
﻿using System;

//Problem 13. Check a Bit at Given Position

//    Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n, has value of 1.

//Examples:
//n 	binary representation of n 	p 	bit @ p == 1
//5 	00000000 00000101 	        2 	true
//0 	00000000 00000000 	        9 	false
//15 	00000000 00001111 	        1 	true
//5343 	00010100 11011111 	        7 	true
//62241 11110011 00100001 	        11 	false

    class BitAtGivvenPosition
    {
        static void Main()
        {
            Console.WriteLine(@"Problem:
Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p 
(counting from 0, starting from the right) in given integer number n, has 
value of 1.

-------------------------------------------------------------------------------
Solution:

");
            Console.WriteLine("Which number you want checked?");
            int bitInteger = int.Parse(Console.ReadLine());
            //If you want the representation in binary of the number to be cheked:
            //Console.WriteLine(Convert.ToString(bitInteger, 2).PadLeft(16, '0'));

            Console.WriteLine("Which index you want checked?");
            int indexP = int.Parse(Console.ReadLine());

            //creating a mask:
            int mask = 1 << indexP;
            //the mask in binary:
            //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));

            //Cheking the bit and storing it to local bool:
            bool oneOrZero = (((bitInteger & mask) >> indexP) == 1);

            //Prints result:
            Console.WriteLine("The bit on position {0} of number {1} is 1: {2}", indexP, bitInteger, oneOrZero);
        }
    }

>>>>>>> .r6
