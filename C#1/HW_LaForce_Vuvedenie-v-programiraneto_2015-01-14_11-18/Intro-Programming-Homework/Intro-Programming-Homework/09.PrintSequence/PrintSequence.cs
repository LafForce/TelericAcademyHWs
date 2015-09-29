<<<<<<< .mine
﻿using System;

//### Problem 9.	Print a Sequence
//*	Write a program that prints the first 10 members of the sequence: `2, -3, 4, -5, 6, -7, ...`

namespace Print
{
    class PrintSequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(-i);
            //I heard that it is not good to print mid-cicle but that's my solution, and it looks like it works.
        }
    }
}
||||||| .r0
=======
﻿using System;

//### Problem 9.	Print a Sequence
//*	Write a program that prints the first 10 members of the sequence: `2, -3, 4, -5, 6, -7, ...`

namespace Print
{
    class PrintSequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(-i);
            //I heard that it is not good to print mid-cicle but that's my solution, and it looks like it works.
        }
    }
}
>>>>>>> .r6
