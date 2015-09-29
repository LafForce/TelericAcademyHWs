using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonClass
{
    //    Problem 4. Person class
    //Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
    //Override ToString() to display the information of a person and if age is not specified – to say so.
    //Write a program to test this functionality.

    class Person
    {
        private string name = null;
        private int? age = null;

        public Person()
        {
        }
        
        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name can not be null!");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(String.Format("This person's name is:{0} \nIts age is: {1}"
                                            , this.name, this.age == null ? " Age is left balnk1" : this.age.ToString()));

            return result.ToString();
        }


        static void Main(string[] args)
        {
            Person gosho = new Person("");
            Console.WriteLine(gosho.ToString());
        }
    }
}
