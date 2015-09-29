//Problem 1. School classes
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes and operations,
//encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace _01.SchoolClasses
{
    using System;

    class Execute
    {
        static void Main()
        {
            School oldSchool = new School("How High Highscool");

            Class classOne = new Class("A1");
            Class classTwo = new Class("A2");
            Class classThree = new Class("B1");

            Teacher teacherOne = new Teacher("Gerasim", "an old ba*tard!");
            Teacher teacherTwo = new Teacher("Gerasimov");

            Student studentOne = new Student("Ivan", "123456", "ladies type");
            Student studentTwo = new Student("Petkan", "123457", "zubar1");
            Student studentThree = new Student("Gosho", "123458");
            Student studentFour = new Student("Krasimir", "123459", "pich");
            Student studentFive = new Student("Ivan", "0000001");

            Discipline chovekIPriroda = new Discipline("CIP", 5, 10);
            Discipline history = new Discipline("History", 3, 6, "...the story of it all ");
            Discipline geography = new Discipline("Geography", 3, 6);
            Discipline literature = new Discipline("Literature", 2, 4, "Russian classics basically");

            oldSchool.AddClass(classOne);
            oldSchool.AddClass(classTwo);
            oldSchool.AddClass(classThree);

            teacherOne.AddDiscipline(chovekIPriroda);
            teacherOne.AddDiscipline(literature);
            teacherTwo.AddDiscipline(history);
            teacherTwo.AddDiscipline(geography);

            classOne.AddStudentToAClass(studentOne);
            classOne.AddStudentToAClass(studentTwo);
            classTwo.AddStudentToAClass(studentThree);
            classThree.AddStudentToAClass(studentFour);
            classThree.AddStudentToAClass(studentFive);

            classOne.AddTeacherToAClass(teacherOne);
            classOne.AddTeacherToAClass(teacherTwo);
            classTwo.AddTeacherToAClass(teacherOne);
            classThree.AddTeacherToAClass(teacherTwo);

            Console.WriteLine("The school {0} has {1} the fololing classes: \n\n {2} {3} {4}", oldSchool.Name, oldSchool.Classes.Count, classOne, classTwo, classThree);
        }
    }
}
