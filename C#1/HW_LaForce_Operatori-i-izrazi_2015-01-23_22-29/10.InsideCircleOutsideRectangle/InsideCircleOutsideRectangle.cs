<<<<<<< .mine
﻿using System;

//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

//Examples:
//x 	y 	inside K & outside of R
//1 	2 	yes
//2.5 	2 	no
//0 	1 	no
//2.5 	1 	no
//2 	0 	no
//4 	0 	no
//2.5 	1.5 	no
//2 	1.5 	yes
//1 	2.5 	yes
//-100 	-100 	no


class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2).

-------------------------------------------------------------------------------
Solution:

");

        Console.WriteLine("Insert \"x\" coordinate, please.");
        double xCoord = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert \"y\" coordinate, please.");
        double yCoord = double.Parse(Console.ReadLine());
        Console.WriteLine();
        
       
        bool isInsideCircle = Math.Pow((xCoord - 1), 2) + Math.Pow((yCoord - 1), 2) <= Math.Pow((1.5), 2);
       
        
        bool isOutsideRectangle = (((xCoord < -2) || (xCoord > 5)) || ((yCoord < -1) || (yCoord > 1)));
        
        //Console.WriteLine(isInsideCircle);
       
        //Console.WriteLine(isOutsideRectangle);

        bool isTrue = isInsideCircle && isOutsideRectangle;

        Console.WriteLine("Is the point inside the circle K and outside the rectangle R? {0}", isTrue ? "Yes" : "No");

    }
}
||||||| .r0
=======
﻿using System;

//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

//Examples:
//x 	y 	inside K & outside of R
//1 	2 	yes
//2.5 	2 	no
//0 	1 	no
//2.5 	1 	no
//2 	0 	no
//4 	0 	no
//2.5 	1.5 	no
//2 	1.5 	yes
//1 	2.5 	yes
//-100 	-100 	no


class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2).

-------------------------------------------------------------------------------
Solution:

");

        Console.WriteLine("Insert \"x\" coordinate, please.");
        double xCoord = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert \"y\" coordinate, please.");
        double yCoord = double.Parse(Console.ReadLine());
        Console.WriteLine();
        
       
        bool isInsideCircle = Math.Pow((xCoord - 1), 2) + Math.Pow((yCoord - 1), 2) <= Math.Pow((1.5), 2);
       
        
        bool isOutsideRectangle = (((xCoord < -2) || (xCoord > 5)) || ((yCoord < -1) || (yCoord > 1)));
        
        //Console.WriteLine(isInsideCircle);
       
        //Console.WriteLine(isOutsideRectangle);

        bool isTrue = isInsideCircle && isOutsideRectangle;

        Console.WriteLine("Is the point inside the circle K and outside the rectangle R? {0}", isTrue ? "Yes" : "No");

    }
}
>>>>>>> .r6
