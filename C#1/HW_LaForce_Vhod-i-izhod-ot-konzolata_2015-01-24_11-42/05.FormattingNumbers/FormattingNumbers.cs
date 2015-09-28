using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Formatting Numbers
*	Write a program that reads 3 numbers:
*	integer `a` (0 <= a <= 500)
*	floating-point `b`
*	floating-point `c` 
*	The program then prints them in 4 virtual columns on the console. 
Each column should have a width of 10 characters.	
*	The number `a` should be printed in hexadecimal, left aligned
*	Then the number `a` should be printed in binary form, padded 
with zeroes
*	The number `b` should be printed with 2 digits after the decimal 
point, right aligned
*	The number c should be printed with 3 digits after the decimal 
point, left aligned. 
	_Examples:_
|  a  |    b    |    c    |                      result                    |
|:---:|:-------:|:-------:|------------------------------------------------|
| 254 | 11.6    | 0.5     | `FE        |0011111110|     11.60|0.500     |` |
| 499 | -0.5559 | 10000   | `1F3       |0111110011|     -0.56|10000     |` |
| 0   | 3       | -0.1234 | `0         |0000000000|         3|-0.123    |` |

-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Insert integer(0 <= a <= 500) a's value, please.");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's b value, please.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert number's c value, please.");
        double c = double.Parse(Console.ReadLine());

        string aBinary = Convert.ToString(a, 2).PadLeft(10, '0');

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, aBinary, b, c);
    }
}

