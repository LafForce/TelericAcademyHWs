//Problem 2. Students and workers
//    Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace StudentsWorkers
{
    using StudentsAndWorkers;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Execute
    {
        static void Main()
        {
            var allStudents = InitializeStudents();
            var allWorkers = InitializeWorkers();

            var sortedStudents = SortStudentsByGrade(allStudents);
            Console.WriteLine("Students sorted by their grade: ");
            PrintResult(sortedStudents);

            Console.WriteLine();

            var sortedWorkers = SortWorkersByMPHDescending(allWorkers);
            Console.WriteLine("Workers sorted by money per hour earned: ");
            PrintResult(sortedWorkers);

            Console.WriteLine();

            List<Human> mergedList = MergeTwoLists(sortedStudents, sortedWorkers);
            List<Human> orderedHumans = OrderHumansByFirstAndLasrName(mergedList);
            Console.WriteLine("Students and workers sorted by their first and last names: ");
            PrintHumans(orderedHumans);
        }

        private static void PrintResult<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write("- {0}", item);
            }
        }

        private static void PrintHumans(IEnumerable<Human> orderedHumans)
        {
            foreach (var human in orderedHumans)
            {
                Console.WriteLine("- {0} {1}", human.FirstName, human.LastName);
            }
        }

        private static List<Human> OrderHumansByFirstAndLasrName(IEnumerable<Human> mergedList)
        {
            var result = mergedList.OrderBy(x => x.FirstName)
                                   .ThenBy(x => x.LastName)
                                   .ToList();

            return result;
        }

        private static List<Human> MergeTwoLists(IEnumerable<Student> sortedStudents, IEnumerable<Worker> sortedWorkers)
        {
            List<Human> result = new List<Human>();

            result.AddRange(sortedStudents);
            result.AddRange(sortedWorkers);

            return result;
        }

        private static List<Worker> SortWorkersByMPHDescending(IEnumerable<Worker> allWorkers)
        {
            var result = allWorkers.OrderByDescending(x => x.CalculateMoneyPerHour())
                                   .ToList();

            return result;
        }

        private static List<Student> SortStudentsByGrade(IEnumerable<Student> allStudents)
        {
            var result = allStudents.OrderBy(x => x.Grade)
                                    .ToList();

            return result;
        }

        private static List<Worker> InitializeWorkers()
        {
            List<Worker> allWorkers = new List<Worker>();

            allWorkers.Add(new Worker("Pesho", "Peshov", 1500, 8));
            allWorkers.Add(new Worker("Pesho", "Goshov", 4400, 2));
            allWorkers.Add(new Worker("Pesho", "Toshov", 450, 13));
            allWorkers.Add(new Worker("Alex", "Petrov", 1500, 8));
            allWorkers.Add(new Worker("Vasil", "Petrov", 465, 4));
            allWorkers.Add(new Worker("Alexandra", "Alexandrova", 755, 8));
            allWorkers.Add(new Worker("Ali", "Baliev", 355, 8));
            allWorkers.Add(new Worker("Todor", "Todorov", 155, 18));
            allWorkers.Add(new Worker("Gergana", "Ptrova", 652, 8));
            allWorkers.Add(new Worker("Gergana", "Poptodorova", 7150, 1));

            return allWorkers;

        }

        private static List<Student> InitializeStudents()
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Ivan", "Kolev", 10));
            allStudents.Add(new Student("Ivan", "Georgiev", 12));
            allStudents.Add(new Student("Iva", "Hristova", 9));
            allStudents.Add(new Student("Ivanka", "Hristova", 5));
            allStudents.Add(new Student("Kamen", "Stoqnov", 9));
            allStudents.Add(new Student("Alisia", "Koleva", 8));
            allStudents.Add(new Student("Alis", "Koleva", 7));
            allStudents.Add(new Student("Alisa", "Hristozov", 11));
            allStudents.Add(new Student("Pencho", "Krasimirov", 7));
            allStudents.Add(new Student("Mara", "Krasimirova", 4));

            return allStudents;
        }
    }
}
