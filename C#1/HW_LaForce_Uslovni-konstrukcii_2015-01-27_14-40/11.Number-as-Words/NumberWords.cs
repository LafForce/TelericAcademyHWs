using System;
using System.Globalization;
using System.Threading;
class NumberWords
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Number as Words
*Write a program that converts a number in the range [0…999] to words,
corresponding to the English pronunciation.
_Examples:_
| numbers | number as words               | 
|---------|-------------------------------|-
| 0       | Zero                          | 
| 9       | Nine                          | 
| 10      | Ten                           | 
| 12      | Twelve                        | 
| 19      | Nineteen                      | 
| 25      | Twenty five                   | 
| 98      | Ninety eight                  | 
| 98      | Ninety eight                  | 
| 273     | Two hundred and seventy three | 
| 400     | Four hundred                  | 
| 501     | Five hundred and one          | 
| 617     | Six hundred and seventeen     | 
| 711     | Seven hundred and eleven      | 
| 999     | Nine hundred and ninety nine  |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Insert a int in the interval [0…999]");
        int number = int.Parse(Console.ReadLine());

        int edinici = 0;
        int desetici = 0;
        int stotici = 0;

        string dumaSto = "";
        string dumaDeset = "";
        string dumaEdno = "";

        if (number >= 0 && number <= 999)
        {

            edinici = number % 10;
            desetici = (number / 10) % 10;
            stotici = number / 100;

            switch (stotici)
            {
                case 1:
                    dumaSto = "One hundred and";
                    break;
                case 2:
                    dumaSto = "Two hundred and";
                    break;
                case 3:
                    dumaSto = "Three hundred and";
                    break;
                case 4:
                    dumaSto = "Four hundred and";
                    break;
                case 5:
                    dumaSto = "Five hundred and";
                    break;
                case 6:
                    dumaSto = "Six hundred and";
                    break;
                case 7:
                    dumaSto = "Seven hundred and";
                    break;
                case 8:
                    dumaSto = "Eight hundred and";
                    break;
                case 9:
                    dumaSto = "Nine hundred and";
                    break;
            }

            switch (desetici)
            {
                case 1: //the teen case:
                    switch (edinici)
                    {
                        case 1:
                            dumaEdno = " eleven";
                            break;
                        case 2:
                            dumaEdno = " twelve";
                            break;
                        case 3:
                            dumaEdno = " thirteen";
                            break;
                        case 4:
                            dumaEdno = " fourteen";
                            break;
                        case 5:
                            dumaEdno = " fifteen";
                            break;
                        case 6:
                            dumaEdno = " sixteen";
                            break;
                        case 7:
                            dumaEdno = " seventeen";
                            break;
                        case 8:
                            dumaEdno = " eighteen";
                            break;
                        case 9:
                            dumaEdno = " nineteen";
                            break;
                    }

                    break;
                case 2:
                    dumaDeset = " twenty";
                    break;
                case 3:
                    dumaDeset = " thirty";
                    break;
                case 4:
                    dumaDeset = " forty";
                    break;
                case 5:
                    dumaDeset = " fifty";
                    break;
                case 6:
                    dumaDeset = " sixty";
                    break;
                case 7:
                    dumaDeset = " seventy";
                    break;
                case 8:
                    dumaDeset = " eighty";
                    break;
                case 9:
                    dumaDeset = " ninety";
                    break;
            }

            if (desetici != 1)
            {
                switch (edinici)
                {
                    case 1:
                        dumaEdno = " one";
                        break;
                    case 2:
                        dumaEdno = " two";
                        break;
                    case 3:
                        dumaEdno = " three";
                        break;
                    case 4:
                        dumaEdno = " four";
                        break;
                    case 5:
                        dumaEdno = " five";
                        break;
                    case 6:
                        dumaEdno = " six";
                        break;
                    case 7:
                        dumaEdno = " seven";
                        break;
                    case 8:
                        dumaEdno = " eight";
                        break;
                    case 9:
                        dumaEdno = " nine";
                        break;
                }
            }

            //result:
            Console.WriteLine(dumaSto + dumaDeset + dumaEdno);
        }
        else
        {
            Console.WriteLine("outside of range");
        }
    }
}





























//this took way too much of my time. Good damn those upper cases are annoyning.. and and's are the devill
