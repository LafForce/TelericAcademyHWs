//Define new class Student which is derived from Human and has new field – grade. 

namespace StudentsAndWorkers
{
    using System;
    using System.Text;

    class Student : Human
    {

        private int grade;


        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grades are only between 1 and 12!");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} is in {1} grade", base.ToString(), this.Grade));

            return result.ToString();
        }

    }
}
