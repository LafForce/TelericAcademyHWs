using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class OneForAll
{
    static void Main()
    {
        Console.WriteLine(@"Problem 7. One system to any other
Write a program to convert from any numeral system of given base s to any 
other numeral system of base d (2 ≤ s, d ≤ 16).
============================================================================
Solution:");
        Console.WriteLine("Enter the initial base, please.");
        int baseX = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Enter final base, please.");
        int baseY = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number in base {0} to be represented to base {1}, please.");
        string number = Console.ReadLine();

        Console.WriteLine(BaseXToBaseY(number, baseX, baseY));
    }

    static char GetChar(int i)
    {
        if (i >= 10)
        {
            return (char)('A' + i - 10);
        }
        else
        {
            return (char)('0' + i);
        }
    }

    static int GetNumber(string s, int i)
    {
        if (s[i] >= 'A')
        {
            return s[i] - 'A' + 10;
        }
        else 
        {
             return s[i] - '0';
        }
    }
    static string Base10ToBaseX(int d, int x)
    {
        string h = String.Empty;
        char ch;
        for (; d != 0; d /= x)
        {
            ch = GetChar(d % x);
            h = ch + h;
        }
        return h;
    }

    static int BaseXToBase10(string h, int x)
    {
        int d = 0;
        int number;
        for (int i = h.Length - 1, p = 1; i >= 0; i--, p *= x)
        {
            number = GetNumber(h, i);
            d += number * p;
        }
        return d;
    }

    static string BaseXToBaseY(string n, int x, int y)
    {
        return Base10ToBaseX(BaseXToBase10(n, x), y); 
    }
   
}
