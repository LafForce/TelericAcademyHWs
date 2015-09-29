//Each teacher teaches a set of disciplines. 
//Teachers have name. 

namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People, ICommentable
    {
        private List<Discipline> disciplines;
        private string comment;

        public Teacher(string name)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
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

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }
    }
}
