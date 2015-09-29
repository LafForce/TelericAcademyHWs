<<<<<<< .mine
﻿using System;

//### Problem 3.	Divide by 7 and 5
//*	Write a Boolean expression that checks for given integer if it can be divided (without remainder) by `7` and `5` at the same time.

//_Examples:_

//|  n  | Divided by 7 and 5? |
//|:---:|:-------------------:|
//| 3   | false               |
//| 0   | false               |
//| 5   | false               |
//| 7   | false               |
//| 35  | true                |
//| 140 | true                |

    class DivideBySevenAndFive
    {
        static void Main()
        {
            Console.WriteLine(@"Problem:
Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided 
(without remainder) by `7` and `5` at the same time.

--------------------------------------------------------------------------------
Solution:

");
             //Get the number to be checked:
            Console.WriteLine("Which number do you want to check for division without reminder by 7 & 5?");
            int divMonkey = int.Parse(System.Console.ReadLine());

            //Check:
            bool itCanBeDone = ((divMonkey % 7) == 0) && ((divMonkey % 5) == 0);
            //obviously "bool itCanBeDone = (divMonkey % 35 == 0);" would return the same result...
            

            //Results on the console:
            Console.WriteLine("So, is it true that {0} can be divided (without remainder) by `7` and `5` at the same time: {1}"
                , divMonkey, itCanBeDone ? "Yes" : "No");
            //Is this new line mid WriteLine out of the convention for quality code for C#? I really don't know but it 
            //looked better and reeded easier on  my screen... and it works just fine.
        }
    }
||||||| .r0
=======
﻿using System;

//### Problem 3.	Divide by 7 and 5
//*	Write a Boolean expression that checks for given integer if it can be divided (without remainder) by `7` and `5` at the same time.

//_Examples:_

//|  n  | Divided by 7 and 5? |
//|:---:|:-------------------:|
//| 3   | false               |
//| 0   | false               |
//| 5   | false               |
//| 7   | false               |
//| 35  | true                |
//| 140 | true                |

    class DivideBySevenAndFive
    {
        static void Main()
        {
            Console.WriteLine(@"Problem:
Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided 
(without remainder) by `7` and `5` at the same time.

--------------------------------------------------------------------------------
Solution:

");
             //Get the number to be checked:
            Console.WriteLine("Which number do you want to check for division without reminder by 7 & 5?");
            int divMonkey = int.Parse(System.Console.ReadLine());

            //Check:
            bool itCanBeDone = ((divMonkey % 7) == 0) && ((divMonkey % 5) == 0);
            //obviously "bool itCanBeDone = (divMonkey % 35 == 0);" would return the same result...
            

            //Results on the console:
            Console.WriteLine("So, is it true that {0} can be divided (without remainder) by `7` and `5` at the same time: {1}"
                , divMonkey, itCanBeDone ? "Yes" : "No");
            //Is this new line mid WriteLine out of the convention for quality code for C#? I really don't know but it 
            //looked better and reeded easier on  my screen... and it works just fine.
        }
    }
>>>>>>> .r6
