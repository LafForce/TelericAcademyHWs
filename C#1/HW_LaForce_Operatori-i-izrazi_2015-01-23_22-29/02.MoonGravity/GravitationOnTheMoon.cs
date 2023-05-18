using System;

//### Problem 2.	Gravitation on the Moon
//*	The gravitational field of the Moon is approximately `17%` of that on the Earth.
//*	Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

//_Examples:_

//| weight | weight on the Moon |
//|:------:|:------------------:|
//| 86     | 14.62              |
//| 74.6   | 12.682             |
//| 53.7   | 9.129              |


    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine(@"Problem:
Gravitation on the Moon
The gravitational field of the Moon is approximately `17%` of that on the 
Earth. Write a program that calculates the weight of a man on the moon by a 
given weight on the Earth.
--------------------------------------------------------------------------------
Solution:

");
            //Get the mass of the man on the Eath:
            Console.WriteLine("How much does the man weights on Earth?");
            int eathG = int.Parse(System.Console.ReadLine());

            //Calculation should set floating point for eartG to show fraction in the result:
            float moonG = ((17 * (float)eathG) / 100);

            //Result on the console:
            Console.WriteLine("The weight of the man on the surface of the Moon should be:");
            Console.WriteLine("..........................................................{0}", moonG);
        }
    }

