<<<<<<< .mine
﻿using System;

//Problem 7. Point in a Circle
//    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//Examples:
//x 	y 	inside
//0 	1 	true
//-2 	0 	true
//-1 	2 	false
//1.5 	-1 	true
//-1.5 	-1.5 	false
//100 	-30 	false
//0 	0 	true
//0.2 	-0.8 	true
//0.9 	-1.93 	false
//1 	1.655 	true


class PointInCircle
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle 
K({0, 0}, 2).

-------------------------------------------------------------------------------
Solution:

");

        const double radius = 2;

        Console.WriteLine("The circles center is on x=0, y=0 and its radius is 2");
        Console.WriteLine();

        //!!!the decimal separator on any computer may be comma or dot! it causes crashes and mistakes! 
        //pls be careful
        Console.WriteLine("Insert \"x\" coordinate, please.");
        double xCoord = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert \"y\" coordinate, please.");
        double yCoord = double.Parse(Console.ReadLine());
        Console.WriteLine();

        bool isInside = Math.Pow(xCoord, 2) + Math.Pow(yCoord, 2) <= Math.Pow(radius, 2);
        Console.WriteLine("The point with coordinates x= {0} and y= {1} is {2} the circles' boundaries"
                          , xCoord, yCoord, isInside ? "inside" : "outside");
        //Console.WriteLine(isInside);
    
    
    }

}
||||||| .r0
=======
﻿using System;

//Problem 7. Point in a Circle
//    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//Examples:
//x 	y 	inside
//0 	1 	true
//-2 	0 	true
//-1 	2 	false
//1.5 	-1 	true
//-1.5 	-1.5 	false
//100 	-30 	false
//0 	0 	true
//0.2 	-0.8 	true
//0.9 	-1.93 	false
//1 	1.655 	true


class PointInCircle
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle 
K({0, 0}, 2).

-------------------------------------------------------------------------------
Solution:

");

        const double radius = 2;

        Console.WriteLine("The circles center is on x=0, y=0 and its radius is 2");
        Console.WriteLine();

        //!!!the decimal separator on any computer may be comma or dot! it causes crashes and mistakes! 
        //pls be careful
        Console.WriteLine("Insert \"x\" coordinate, please.");
        double xCoord = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert \"y\" coordinate, please.");
        double yCoord = double.Parse(Console.ReadLine());
        Console.WriteLine();

        bool isInside = Math.Pow(xCoord, 2) + Math.Pow(yCoord, 2) <= Math.Pow(radius, 2);
        Console.WriteLine("The point with coordinates x= {0} and y= {1} is {2} the circles' boundaries"
                          , xCoord, yCoord, isInside ? "inside" : "outside");
        //Console.WriteLine(isInside);
    
    
    }

}
>>>>>>> .r6
