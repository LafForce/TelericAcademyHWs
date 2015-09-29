<<<<<<< .mine
﻿using System;

//Problem 9. Trapezoids
//    Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Examples:
//a 	b 	h 	area
//5 	7 	12 	72
//2 	1 	33 	49.5
//8.5 	4.3 	2.7 	17.28
//100 	200 	300 	45000
//0.222 	0.333 	0.555 	0.1540125



class Trapezoids
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b 
and height h.
-------------------------------------------------------------------------------
Solution:

");
        //Get the dimensions of the trapezoid:
        Console.WriteLine("Please insert the number for the \"a\" side:");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Please insert the number for the \"b\" side::");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Please insert the number for the height \"h\":");
        float h = float.Parse(Console.ReadLine());

        //Next line calculates and prints the area fo the trapezoid:
        Console.WriteLine(((a+b) / 2) * h);

    }
}

||||||| .r0
=======
﻿using System;

//Problem 9. Trapezoids
//    Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Examples:
//a 	b 	h 	area
//5 	7 	12 	72
//2 	1 	33 	49.5
//8.5 	4.3 	2.7 	17.28
//100 	200 	300 	45000
//0.222 	0.333 	0.555 	0.1540125



class Trapezoids
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b 
and height h.
-------------------------------------------------------------------------------
Solution:

");
        //Get the dimensions of the trapezoid:
        Console.WriteLine("Please insert the number for the \"a\" side:");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Please insert the number for the \"b\" side::");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Please insert the number for the height \"h\":");
        float h = float.Parse(Console.ReadLine());

        //Next line calculates and prints the area fo the trapezoid:
        Console.WriteLine(((a+b) / 2) * h);

    }
}

>>>>>>> .r6
