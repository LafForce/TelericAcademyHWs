//We are given a school. In the school there are classes of students. 

namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class School
    {
        private string name;
        private List<Class> classes;

        public School(string name)
        {
            this.Name = name;
            this.classes = new List<Class>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("There must be a name for this school!");
                }
                this.name = value;
            }
        }

        public List<Class> Classes
        {
            get
            {
                return new List<Class>(this.classes);
            }
        }

        public void AddClass(Class newClass)
        {
            this.classes.Add(newClass);
        }
    }
}
