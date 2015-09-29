<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Threading;


class Circle

{

    static void Main()
    {
        Console.WriteLine(@"Problem:
Circle Perimeter and Area
*	Write a program that reads the radius `r` of a circle and prints its 
perimeter and area formatted with `2` digits after the decimal point.
_Examples:_
|          r          |          perimeter         |  area |
|:-------------------:|:--------------------------:|:-----:|
| 2                   | 12.57                      | 12.57 |
| 3.5                 | 21.99                      | 38.48 |.

-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert the radius `r` of the circle, please.");
        double r = double.Parse(Console.ReadLine());


        Console.WriteLine("The perimeter of the circle with radius {0} is: {1:0.00}\n its area is: {2:0.00}"
                           , r , Math.PI * 2 * r, Math.PI * Math.Pow(r, 2));

    }
}
||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Threading;


class Circle

{

    static void Main()
    {
        Console.WriteLine(@"Problem:
Circle Perimeter and Area
*	Write a program that reads the radius `r` of a circle and prints its 
perimeter and area formatted with `2` digits after the decimal point.
_Examples:_
|          r          |          perimeter         |  area |
|:-------------------:|:--------------------------:|:-----:|
| 2                   | 12.57                      | 12.57 |
| 3.5                 | 21.99                      | 38.48 |.

-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert the radius `r` of the circle, please.");
        double r = double.Parse(Console.ReadLine());


        Console.WriteLine("The perimeter of the circle with radius {0} is: {1:0.00}\n its area is: {2:0.00}"
                           , r , Math.PI * 2 * r, Math.PI * Math.Pow(r, 2));

    }
}
>>>>>>> .r6
