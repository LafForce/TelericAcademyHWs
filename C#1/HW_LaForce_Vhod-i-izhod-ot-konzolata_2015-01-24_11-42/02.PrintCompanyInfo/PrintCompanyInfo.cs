using System;
using System.Globalization;
using System.Threading;

class PrintCompanyInformation

{

    static void Main()
    {
        Console.WriteLine(@"Problem:
Print Company Information
*	A company has name, address, phone number, fax number, web site and 
manager. The manager has first name, last name, age and a phone number.
*	Write a program that reads the information about a company and its 
manager and prints it back on the console.
Example input:_

|       program       |            user            |
|---------------------|----------------------------|
| Company name:       | Telerik Academy            |
| Company address:    | 31 Al. Malinov, Sofia      |
| Phone number:       | +359 888 55 55 555         |
| Fax number:         | 2                          |
| Web site:           | http://telerikacademy.com/ |
| Manager first name: | Nikolay                    |
| Manager last name:  | Kostov                     |
| Manager age:        | 25                         |
| Manager phone:      | +359 2 981 981             |

_Example output:_

	Telerik Academy
	Address: 231 Al. Malinov, Sofia
	Tel. +359 888 55 55 555
	Fax: (no fax)
	Web site: http://telerikacademy.com/
	Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)	

-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


        //ready input:
        //string companyName = "Telerik Academy";
        //string companyAddress = "31 Al. Malinov, Sofia";
        //string phoneNum = "+359 888 55 55 555";
        //string faxNumber = "(no fax)"; // I should add type check but...
        //string webSite = "http://telerikacademy.com/" ;
        //string firstName = "Nikolay";
        //string lastName = "Kostov";
        //string mangerAge = "25";
        //string managPhone = "+359 2 981 981";

        Console.WriteLine("Insert company's name, please.");
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Insert phone number, please.");
        string phoneNum = Console.ReadLine();
        Console.WriteLine("Insert fax number, please.");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Insert web site, please.");
        string webSite = Console.ReadLine();
        Console.WriteLine("Insert manager's first name, please.");
        string firstName = Console.ReadLine();
        Console.WriteLine("Insert manager's last name, please.");
        string lastName = Console.ReadLine();
        Console.WriteLine("Insert manager's age, please.");
        string mangerAge = Console.ReadLine();
        Console.WriteLine("Insert manager's phone, please.");
        string managPhone = Console.ReadLine();

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8},"
            , companyName, companyAddress, phoneNum, faxNumber, webSite, firstName, lastName, mangerAge, managPhone);


    }
}