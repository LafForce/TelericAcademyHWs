using System;
using System.Globalization;

class Workdays
{

    static string[] listHolidays = { "02 03 2015",
"03 03 2015",
"10 04 2015",
"13 04 2015",
"01 05 2015",
"06 05 2015",
"21 09 2015",
"22 09 2015",
"24 12 2015",
"25 12 2015" };

    static void Main()
    {
        Console.WriteLine(@"Problem 5. Workdays
Write a method that calculates the number of workdays between today and 
given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed 
list of public holidays specified preliminary as array.
============================================================================
Solution:");
        Console.WriteLine("Enter date in the future to count the workdays to.");
        Console.WriteLine("Use \"dd MM yyyy\" (separated by space) format, please");
        DateTime day = DateTime.ParseExact(Console.ReadLine(), "dd MM yyyy", new CultureInfo("bg-BG"));

        Console.WriteLine("There are {0} workdays untill {1}! ", CountEm(day), day.ToString("dd MM yyyy"));

    }
    static int CountEm(DateTime dayX)
    {   
        DateTime now = DateTime.Now;
        int count = 0;
        for (int i = now.DayOfYear; i < dayX.DayOfYear; i++)
        {
            DateTime current = new DateTime(dayX.Year, 1, 1).AddDays(i - 1);
            if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday)
            {
                count++;
            }
        }
        for (int j = 0; j < listHolidays.Length; j++)
        {
            DateTime special = DateTime.ParseExact(listHolidays[j], "dd MM yyyy", new CultureInfo("bg-BG"),
                              DateTimeStyles.None);
            if (special.DayOfYear > now.DayOfYear && special.DayOfYear < dayX.DayOfYear)
            {
                count--;
            }
        }

        return count;
    }
}
