<<<<<<< .mine
﻿using System;

//### Problem 15.*	Age after 10 Years
//*	Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

namespace AgeAfter
{
    class Age
    {
        static void Main(string[] args)
        {
            //Hoping that the user will read and insert the date in correct format or it breaks:)
            Console.WriteLine("When were you born?");
            Console.WriteLine("Please, write the date in the format: \"dd MM yyyy\" or else it may not work.)");

            //storing the birth and current date to lockal
            DateTime now = DateTime.Now;
            DateTime birthDay = DateTime.Parse(System.Console.ReadLine());

            ////Calculating the ages:
            int age = now.Year - birthDay.Year;

            //Correction for if b-day has passed for the current year:
            if (birthDay.Month == now.Month && birthDay.Day <= now.Day)
            {
                age--;
            }
            if (birthDay.Month > now.Month)
            {
                age--;
            }

            // since "ageafter10" is dependent on "age" I calculate it after the age
            int ageAfterTen = age + 10;

            //The results on the console:
            Console.WriteLine("Your b-day is: " + birthDay.ToShortDateString());
            Console.WriteLine("Your are: " + age + " years old.");
            Console.WriteLine("After 10 years your age will be: " + ageAfterTen + " years old.");
        }
    }
}
||||||| .r0
=======
﻿using System;

//### Problem 15.*	Age after 10 Years
//*	Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

namespace AgeAfter
{
    class Age
    {
        static void Main(string[] args)
        {
            //Hoping that the user will read and insert the date in correct format or it breaks:)
            Console.WriteLine("When were you born?");
            Console.WriteLine("Please, write the date in the format: \"dd MM yyyy\" or else it may not work.)");

            //storing the birth and current date to lockal
            DateTime now = DateTime.Now;
            DateTime birthDay = DateTime.Parse(System.Console.ReadLine());

            ////Calculating the ages:
            int age = now.Year - birthDay.Year;

            //Correction for if b-day has passed for the current year:
            if (birthDay.Month == now.Month && birthDay.Day <= now.Day)
            {
                age--;
            }
            if (birthDay.Month > now.Month)
            {
                age--;
            }

            // since "ageafter10" is dependent on "age" I calculate it after the age
            int ageAfterTen = age + 10;

            //The results on the console:
            Console.WriteLine("Your b-day is: " + birthDay.ToShortDateString());
            Console.WriteLine("Your are: " + age + " years old.");
            Console.WriteLine("After 10 years your age will be: " + ageAfterTen + " years old.");
        }
    }
}
>>>>>>> .r6
