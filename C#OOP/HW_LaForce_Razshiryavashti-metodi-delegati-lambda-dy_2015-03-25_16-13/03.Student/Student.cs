using System;
using System.Collections.Generic;
using System.Linq;


//   Problem 3. First before last
//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.


//    Problem 4. Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//Problem 5. Order students:
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.

class Student
{
    private int age;
    public Student(string nameFirst, string nameLast, int age)
    {
        this.NameFirst = nameFirst;
        this.NameLast = nameLast;
        this.Age = age;
    }

    public string NameFirst { get; set; }

    public string NameLast { get; set; }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 5 && value > 500)
            {
                throw new ArgumentOutOfRangeException("Problems with the age!");
            }
            this.age = value;
        }
    }


    public static IEnumerable<Student> IsFirstBeforeLast(Student[] thisOne)
    {
        IEnumerable<Student> result = from student
                                      in thisOne
                                      where student.NameFirst.CompareTo(student.NameLast) < 0
                                      select student;
        return result;
    }

    public static IEnumerable<Student> AgeRange(Student[] list)
    {
        IEnumerable<Student> result = from student
                                      in list
                                      where student.Age > 18 && student.Age < 24
                                      select student;
        return result;
    }

    public static void DisplayStudent(IEnumerable<Student> listStud)
    {
        Console.WriteLine();
        foreach (var student in listStud)
        {
            Console.WriteLine("Name: {0} {1}, Age: {2}."
        , student.NameFirst, student.NameLast, student.Age);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Student[] classOne = {
                                     new Student("Pesho","Goshov", 17),
                                     new Student("Tosho","Moshev", 23),
                                     new Student("Galia","Hajipoptodorova",16),
                                     new Student("Alex","Yanchev", 17),
                                     new Student("Blagoi","Xpiridonov", 33),
                                     new Student("Yani","Kurtinski", 32),
                                     new Student("Petar","Petrov", 15),
                                     new Student("Vladimira","Svetlinova",22),
                                     new Student("Alex","Makedonski",19)
                                 };

        Console.WriteLine("Problem 3. First before last:");
        DisplayStudent(IsFirstBeforeLast(classOne));
        Console.WriteLine("Press a key for the next task, please!");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Problem 4. Age range:");
        DisplayStudent(AgeRange(classOne));
        Console.WriteLine("Press a key for the next task, please!");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Problem 5. Order students:");
        Console.WriteLine();
        Console.WriteLine("\nUsing lambda:");
        var sortByLambda = classOne.OrderByDescending(x => x.NameFirst).ThenByDescending(x => x.NameLast);
        DisplayStudent(sortByLambda);
        Console.WriteLine();
        Console.WriteLine("\nUsing LINQ:");
        var sortByLINQ = from student
                         in classOne
                         orderby student.NameFirst descending, student.NameLast descending
                         select student;
        DisplayStudent(sortByLINQ);

    }
}
