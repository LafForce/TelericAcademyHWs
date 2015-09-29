//Students have name and unique class number. 

namespace _01.SchoolClasses
{
    using System;

    public class Student : People, ICommentable
    {
        private string classNumber;
        private string comment;

        public Student(string name, string classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, string classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        public string ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Class number is at least 4 symbols long!");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The class number cannot be null!");
                }

                this.classNumber = value;
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
