//Both teachers and students are people. 

namespace _01.SchoolClasses
{
    using System;

    public abstract class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("The name should have at least four letters!");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("There must be a name!");
                }

                this.name = value;
            }
        }
    }
}
