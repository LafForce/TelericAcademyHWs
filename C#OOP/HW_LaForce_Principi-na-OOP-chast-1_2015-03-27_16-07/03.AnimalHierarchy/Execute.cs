//Problem 3. Animal hierarchy
//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only
//female and tomcats can be only male. 
//Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal 
//using a static method (you may use LINQ).
namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Execute
    {
        static void Main()
        {
            AnimalHierarchy.Dog[] dogsArray =
            {
                new AnimalHierarchy.Dog(12, "Reks", AnimalHierarchy.Gender.Male),
                new AnimalHierarchy.Dog(1, "Sharo", AnimalHierarchy.Gender.Male),
                new AnimalHierarchy.Dog(16, "Balkan", AnimalHierarchy.Gender.Female),
                new AnimalHierarchy.Dog(7, "Lasi", AnimalHierarchy.Gender.Female)
            };

            AnimalHierarchy.Cat[] catsArray =
            {
                new AnimalHierarchy.Kitten(1, "LongCat"),
                new AnimalHierarchy.Kitten(2, "lolCat"),
                new AnimalHierarchy.Tomcat(7, "Rosko"),
                new AnimalHierarchy.Tomcat(6, "Lion")
            };

            AnimalHierarchy.Frog[] frogsArray =
            {
                new AnimalHierarchy.Frog(5, "Princess", AnimalHierarchy.Gender.Male),
                new AnimalHierarchy.Frog(2, "Jabcko", AnimalHierarchy.Gender.Male),
                new AnimalHierarchy.Frog(33, "ItalianskaVecherq", AnimalHierarchy.Gender.Female)
            };

            List<AnimalHierarchy.Animal> allAnimals = new List<AnimalHierarchy.Animal>();
            allAnimals.AddRange(dogsArray);
            allAnimals.AddRange(catsArray);
            allAnimals.AddRange(frogsArray);

            Console.WriteLine("Average age of dogs: {0} years.", CalculateAverageYears(dogsArray));
            Console.WriteLine("Average age of cats: {0} years.", CalculateAverageYears(catsArray));
            Console.WriteLine("Average age of frogs: {0} years.", CalculateAverageYears(frogsArray));

            Console.WriteLine();
            Console.WriteLine("Animals:");
            Console.WriteLine();

            foreach (var item in allAnimals)
            {
                Console.WriteLine(item.MakeSound());
            }
        }

        private static double CalculateAverageYears(AnimalHierarchy.Animal[] collection)
        {
            double averageAge = collection.Average(x => x.Age);

            return Math.Round(averageAge, 2);
        }
    }
}
