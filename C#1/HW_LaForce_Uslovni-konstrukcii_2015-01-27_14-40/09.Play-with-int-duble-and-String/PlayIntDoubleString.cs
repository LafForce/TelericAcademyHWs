using System;
using System.Globalization;
using System.Threading;

class PlayIntDoubleString
{
    static void Main()
    {
        Console.WriteLine(@"Problem:
Play with Int, Double and String
*Write a program that, depending on the user’s choice, inputs an `int`, `double`
or `string` variable.
	*If the variable is `int` or `double`, the program increases it by one.
	*If the variable is a `string`, the program appends `*` at the end.
*Print the result at the console. Use switch statement.
_Example 1:_
| program                | user  |
|------------------------|-------|
| Please choose a type:  |       |
| 1 --> int              |       |
| 2 --> double           | 3     |
| 3 --> string           |       |
|                        |       |
| Please enter a string: | hello |
|                        |       |
| hello*                 |       |
-------------------------------------------------------------------------------
Solution:

");
        //Thats because of comma and dot possible input problems:
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine(@"Please choose a type: 
                            1 --> int                     
                            2 --> double                
                            3 --> string");
        try
        {
            int digit = int.Parse(Console.ReadLine());

            try
            {
                switch (digit)
                {
                    case 1:
                        Console.WriteLine("Please enter an int");
                        try
                        {
                            int numberInt = int.Parse(Console.ReadLine()) + 1;
                            Console.WriteLine("Result: " + numberInt);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You have probably not imputed an int number");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Please enter a double type number:");
                        try
                        {
                            double number = double.Parse(Console.ReadLine()) + 1.0d;
                            Console.WriteLine("Result: " + number);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You have probably not a double");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please enter a string:");
                        string strIng = Console.ReadLine();
                        Console.WriteLine("Result: " + strIng + "*");
                        break;
                    default:
                        Console.WriteLine("No such an option");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You have probably imputed an non-integral number type");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
