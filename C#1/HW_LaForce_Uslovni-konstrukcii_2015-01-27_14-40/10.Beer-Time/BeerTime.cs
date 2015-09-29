<<<<<<< .mine
﻿using System; 
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Beer Time
*	A beer time is after `1:00 PM` and before `3:00 AM`.
*	Write a program that enters a time in format “hh:mm tt” (an hour in
range [01...12], a minute in range [00…59] and AM / PM designator) and 
prints `beer time` or `non-beer time` according to the definition above or 
`invalid time` if the time cannot be parsed.
_Note: You may need to learn how to parse dates and times._ 
_Examples:_
| time     | result        |
|----------|---------------|
| 1:00 PM  | beer time     |
| 4:30 PM  | beer time     |
| 10:57 PM | beer time     |
| 8:30 AM  | non-beer time |
| 02:59 AM | beer time     |
| 03:00 AM | non-beer time |
| 03:26 AM | non-beer time |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Insert time “hh:mm tt” to be told if its beer time allready!");
        DateTime timeOtTheBeer;
        DateTime startOfTheBeer = DateTime.Parse("1:00 PM");
        DateTime endOfTheBeer = DateTime.Parse("3:00 AM");
        string stringOfTheBeer = Console.ReadLine();
 
        if (DateTime.TryParseExact(stringOfTheBeer, "h:mm tt", CultureInfo.InvariantCulture,
                                    DateTimeStyles.None, out timeOtTheBeer))
        {
            if (timeOtTheBeer > startOfTheBeer || timeOtTheBeer < endOfTheBeer)
                                       
            {
                Console.WriteLine("|time:         |  result     |\n| {0,-12} |  beer time  |", stringOfTheBeer);
            }
            else
            {
                Console.WriteLine("|time:         |  result     |\n| {0,-12} |non-beer time|", stringOfTheBeer);
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}
||||||| .r0
=======
﻿using System; 
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Beer Time
*	A beer time is after `1:00 PM` and before `3:00 AM`.
*	Write a program that enters a time in format “hh:mm tt” (an hour in
range [01...12], a minute in range [00…59] and AM / PM designator) and 
prints `beer time` or `non-beer time` according to the definition above or 
`invalid time` if the time cannot be parsed.
_Note: You may need to learn how to parse dates and times._ 
_Examples:_
| time     | result        |
|----------|---------------|
| 1:00 PM  | beer time     |
| 4:30 PM  | beer time     |
| 10:57 PM | beer time     |
| 8:30 AM  | non-beer time |
| 02:59 AM | beer time     |
| 03:00 AM | non-beer time |
| 03:26 AM | non-beer time |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Insert time “hh:mm tt” to be told if its beer time allready!");
        DateTime timeOtTheBeer;
        DateTime startOfTheBeer = DateTime.Parse("1:00 PM");
        DateTime endOfTheBeer = DateTime.Parse("3:00 AM");
        string stringOfTheBeer = Console.ReadLine();
 
        if (DateTime.TryParseExact(stringOfTheBeer, "h:mm tt", CultureInfo.InvariantCulture,
                                    DateTimeStyles.None, out timeOtTheBeer))
        {
            if (timeOtTheBeer > startOfTheBeer || timeOtTheBeer < endOfTheBeer)
                                       
            {
                Console.WriteLine("|time:         |  result     |\n| {0,-12} |  beer time  |", stringOfTheBeer);
            }
            else
            {
                Console.WriteLine("|time:         |  result     |\n| {0,-12} |non-beer time|", stringOfTheBeer);
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}
>>>>>>> .r6
