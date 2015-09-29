//Disciplines have name, number of lectures and number of exercises. 

namespace _01.SchoolClasses
{
    using System;

    public class Discipline
    {   
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;
        private string comment;

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.numberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExcercises, string comment)
            : this(name, numberOfLectures, numberOfExcercises)
        {
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name to short!");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("There must be a name of the discipline!");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of lectures should be at least 1!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of excercises should be at least 1!");
                }

                this.numberOfExcercises = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            private set
            {
                this.comment = value;
            }
        }

    }
}
