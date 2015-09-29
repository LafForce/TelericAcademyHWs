using System;

class Triangle
{
    static void Main()
    {
        Console.WriteLine(@"Problem 4. Triangle surface
Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
============================================================================
Solution:");
        Console.WriteLine(@"Which method will you use?
type 1 for side and altitude.
type 2 for thtree sides.
type 3 for two sides and an angle between.");
        try
        {
            int choise = int.Parse(Console.ReadLine());


            if (choise == 1)
            {
                  Surf1();
            }
            else if (choise == 2)
            {
                  Surf2();
            }
            else if (choise == 3)
            {
                  Surf3();
            }
            else
            {
                Console.WriteLine("Wrong choice, I guess!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("You most probably haven't entered the option's number.");
        }
        Console.WriteLine();
    }

    static void Surf1()
    {
        Console.Clear();
        Console.WriteLine("Insert side's mesurement: ");
        double side = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert altitude's mesurement: ");
        double altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("The surface is: {0}", (side * altitude) / 2);
    }

    static void Surf3()
    {
        Console.Clear();

        Console.WriteLine("Insert first side's mesurement: ");
        double side = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert secont side's  mesurement: ");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert the ange between them in grades mesurement: ");
        double angle = double.Parse(Console.ReadLine());
        double angleRad = (Math.PI * angle)/ 180;
        
        Console.WriteLine("The surface is: {0}", ((side * second * Math.Sin(angleRad)) / 2));
    }

    static void Surf2()
    {
        Console.Clear();

        Console.WriteLine("Insert first side's mesurement: ");
        double side = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert secont side's  mesurement: ");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert third side's  mesurement: ");
        double third = double.Parse(Console.ReadLine());

        double p = (side + second + third) / 2;

        Console.WriteLine("The surface is: {0}", Math.Sqrt(p * (p - side) * (p - second) * (p - third)));
    }
}
