namespace AnimalHierarchy
{
    using System;

    abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Type type;
        private Gender gender;

        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public Animal(int age, string name, Gender gender)
            : this(age, name)
        {
            this.gender = gender;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Nothing is that young!");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name must have at least two letters!");
                }
                if (value == null)
                {
                    throw new ArgumentException("there must be a name!");
                }

                this.name = value;
            }
        }

        public Type Type
        {
            get
            {
                return this.type;
            }
            protected set
            {
                this.type = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
        }

        public abstract string MakeSound();
    }
}
