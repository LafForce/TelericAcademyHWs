<<<<<<< .mine
﻿using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
 
   class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem:
Decimal to Binary Number
*Using loops write a program that converts an integer number to its binary 
representation.
*The input is entered as long. The output should be a variable of type string.
*Do not use the built-in .NET functionality.
_Examples:_
| decimal           | binary                       |
|-------------------|------------------------------|
| 0                 | 0                            |
| 3                 | 11                           |
| 43691             | 1010101010101011             |
| 236476736         | 1110000110000101100101000000 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert decimal number, please.");
        long numberDecimal = long.Parse(Console.ReadLine());
        
        //for the first time I use stringbuilder but it is very confortable indeed
        var binary = new StringBuilder();

        long bit = 0;

        while (numberDecimal > 0)
        {
           bit = numberDecimal % 2;
           numberDecimal /= 2;
           binary.Insert(0, bit);
        }
        Console.WriteLine("The binary result is: {0}", binary);
    }
}

||||||| .r0
=======
﻿using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
 
   class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Problem:
Decimal to Binary Number
*Using loops write a program that converts an integer number to its binary 
representation.
*The input is entered as long. The output should be a variable of type string.
*Do not use the built-in .NET functionality.
_Examples:_
| decimal           | binary                       |
|-------------------|------------------------------|
| 0                 | 0                            |
| 3                 | 11                           |
| 43691             | 1010101010101011             |
| 236476736         | 1110000110000101100101000000 |
-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("Insert decimal number, please.");
        long numberDecimal = long.Parse(Console.ReadLine());
        
        //for the first time I use stringbuilder but it is very confortable indeed
        var binary = new StringBuilder();

        long bit = 0;

        while (numberDecimal > 0)
        {
           bit = numberDecimal % 2;
           numberDecimal /= 2;
           binary.Insert(0, bit);
        }
        Console.WriteLine("The binary result is: {0}", binary);
    }
}

>>>>>>> .r6
