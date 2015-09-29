using System;

//Problem 16.** Bit Exchange (Advanced)

//    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} 
//    of a given 32-bit unsigned integer.
//    The first and the second sequence of bits may not overlap.

//Examples:
//n 	        p 	q 	k 	binary representation of n 	            binary result 	                        result
//1140867093 	3 	24 	3 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
//4294901775 	24 	3 	3 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
//2369124121 	2 	22 	10 	10001101 00110101 11110111 00011001 	01110001 10110101 11111000 11010001 	1907751121
//987654321 	2 	8 	11 	- 	                                    - 	                                    overlapping
//123456789 	26 	0 	7 	- 	                                    - 	                                    out of range
//33333333333 	-1 	0 	33 	- 	                                    - 	                                    out of range

class AdvancedBitExchange
{
    static void Main()
    {
        
        Console.WriteLine(@"Problem:
it Exchange (Advanced)
Write a program that excha
Reary input bocks:nges bits {p, p+1, …, p+k-1} 
with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.

----------------------------------------------------------------------------
Solution:

");
        //Case 1:
        //uint n = 1140867093;
        //short p = 3;
        //short q = 24;
        //short k = 3;
        //Case 2:
        //uint n = 4294901775;
        //short p = 24;
        //short q = 3;
        //short k = 3;
        //Case 3:
        //uint n = 2369124121;
        //short p = 2;
        //short q = 22;
        //short k = 10;


        //Manual entry:
        //Get the input numbers:
        Console.WriteLine("Insert number \"n\" to be modified, please");
        uint n = uint.Parse(Console.ReadLine()); //It throws exception anyway if out of rang!

        Console.WriteLine("Insert number \"p\" ");
        short p = short.Parse(Console.ReadLine());
        Console.WriteLine("Insert number \"q\" ");
        short q = short.Parse(Console.ReadLine());
        Console.WriteLine("Insert number \"q\" ");
        short k = short.Parse(Console.ReadLine());

        //check for overlap:
        if (((p + k > q) && (q > p)) || ((p > q) && (q + k > p)))
        {
            Console.WriteLine("Overlapping!");
        }

            //If input is adequate the swap proceeds:
        else
        {
            //I use string string:
            string strNum = Convert.ToString((n), 2).PadLeft(32, '0');
            Console.WriteLine("{0, -15} : {1, -35}", "Binary input:", strNum);

            if (p < q)
            {
                //...and sub-strings
                string strFirst = strNum.Substring(0, 32 - q - k);
                string strQ = strNum.Substring(32 - q - k, k);
                string strMid = strNum.Substring(32 - q, q - k - p);
                string strP = strNum.Substring(32 - p - k, k);
                string strLast = strNum.Substring(32 - p, p);

                //The resulting "binary" string
                string resultStr = (strFirst + strP + strMid + strQ + strLast);
                Console.WriteLine("{0, -15} : {1, -35}", "Binary result:", resultStr);

                //to a u integral number
                uint resultInt = (uint)Convert.ToInt32(resultStr, 2);
                //resulting number:
                Console.WriteLine("{0, -15} : {1, -35}", "Decimal result:", resultInt);
            }

            //Same for if p is larger:
            if (p > q)
            {
                string strFirst = strNum.Substring(0, 32 - p - k);
                string strQ = strNum.Substring(32 - q - k, k);
                string strMid = strNum.Substring(32 - p, p - k - q);
                string strP = strNum.Substring(32 - p - k, k);
                string strLast = strNum.Substring(32 - q, q);

                string resultStr = (strFirst + strQ + strMid + strP + strLast);
                Console.WriteLine("{0, -15} : {1, -35}", "Binary result:", resultStr);
                Console.WriteLine(resultStr.Length);

                uint resultInt = (uint)Convert.ToInt32(resultStr, 2);
                Console.WriteLine("{0, -15} : {1, -35}", "Decimal result:", resultInt);
            }
        }
    }
}











//I am very proud of this prog.... it took me like days to make it work.
