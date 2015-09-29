using System;
using System.IO;
using System.Threading;

class ReadFile
{
    static void Main()
    {
        Console.WriteLine(@"Problem 3. Read file contents
Write a program that enters file name along with its full file path 
(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error 
messages.
============================================================================
Solution:");

        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

        Console.WriteLine(@"Enter the full path of text file on your comuter, please.");

        ////manual
        //string path = Console.ReadLine();

        //auto:
        string path = @"C:\WINDOWS\win.ini";

        try
        {
            string fileContents = File.ReadAllText(path);
            Console.WriteLine(fileContents);
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("Entered not existing path.Try again.");
            Main();
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is a problem with your access rights.");
            Console.WriteLine("Its possible to occur this problem,because you enter a path,without the file (.txt).Try again.");
            Main();
        }
        catch (IOException)
        {
            Console.WriteLine("The file cannot be opened,because now it`s using from other application.Try again.");
            Main();
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Entered empty string.Try again.");
            Main();
        }
    }
}
