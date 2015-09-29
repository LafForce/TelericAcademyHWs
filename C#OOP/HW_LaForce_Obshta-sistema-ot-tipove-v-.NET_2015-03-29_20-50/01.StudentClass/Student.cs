namespace _01.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //    Problem 1. Student class
    //Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile
    // phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
    //Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

    //    Problem 2. IClonable
    //Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

    //Problem 3. IComparable
    //Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by 
    //social security number (as second criteria, in increasing order).
    class Student : ICloneable, IComparable
    {
        private string NameFirst { get; set; }
        private string NameMiddle { get; set; }
        private string NameLast { get; set; }
        private int SSN { get; set; }
        private string Address { get; set; }
        private string Mobile { get; set; }
        private string EMail { get; set; }
        private Specialty Speciality { get; set; }
        private University University { get; set; }
        private Faculty Faculty { get; set; }
        private string Course { get; set; }

        public Student()
        {
        }

        public Student(string name1, string name2, string name3, int SSN, string address, string mobile, string email,
            University uni, Faculty fac, Specialty spec, string course)
        {
            this.NameFirst = name1;
            this.NameMiddle = name2;
            this.NameLast = name3;
            this.SSN = SSN;
            this.Address = address;
            this.Mobile = mobile;
            this.EMail = email;
            this.University = uni;
            this.Faculty = fac;
            this.Speciality = spec;
            this.Course = course;


        }


        

        public object Clone()
        {
            Student temp = new Student(this.NameFirst, this.NameMiddle, this.NameLast, this.SSN, this.Address
                , this.Mobile, this.EMail, this.University, this.Faculty, this.Speciality, this.Course);

            return temp;
        }

        public int CompareTo(object obj)
        {
            if (this.NameFirst.CompareTo((obj as Student).NameFirst) != 0)
            {
                return this.NameFirst.CompareTo((obj as Student).NameFirst);
            }

            if (this.NameMiddle.CompareTo((obj as Student).NameMiddle) != 0)
            {
                return this.NameMiddle.CompareTo((obj as Student).NameMiddle);
            }
            if (this.NameLast.CompareTo((obj as Student).NameLast) != 0)
            {
                return this.NameLast.CompareTo((obj as Student).NameLast);
            }
            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            if (!this.NameFirst.Equals((obj as Student).NameFirst)) return false;
            if (!this.NameMiddle.Equals((obj as Student).NameMiddle)) return false;
            if (!this.NameLast.Equals((obj as Student).NameLast)) return false;
            if (!this.SSN.Equals((obj as Student).SSN)) return false;
            if (!this.Address.Equals((obj as Student).Address)) return false;
            if (!this.Mobile.Equals((obj as Student).Mobile)) return false;
            if (!this.EMail.Equals((obj as Student).EMail)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;
            if (!this.Speciality.Equals((obj as Student).Speciality)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;

            return true;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1.Equals(s2));
        }
        public override int GetHashCode()
        {
            int hash = 42;
            hash = (hash * 11) + this.NameLast.GetHashCode();
            hash = (hash * 11) + this.Course.GetHashCode();
            hash = (hash * 11) + this.NameFirst.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(String.Format("{0} {1} {2}", this.NameFirst, this.NameMiddle, this.NameLast));
            result.AppendLine(String.Format("SSN: {0}", this.SSN));
            result.AppendLine(String.Format("Address: {0}", this.Address));
            result.AppendLine(String.Format("Phone: {0}", this.Mobile));
            result.AppendLine(String.Format("Email: {0}", this.EMail));
            result.AppendLine(String.Format("{0}, faculty: {1}, speciality: {2}, course {3}",
                this.University, this.Faculty, this.Speciality, this.Course));

            return result.ToString();
        }
        static void Main(string[] args)
        {
            Student gosho = new Student();
        }
    }
    enum Specialty
    {
        KSS,
        ComunicationSystems,
        ITMasterGod,
        SoftwareEngineer
    }

    enum University
    {
        TUSofia,
        SofiaUniversity,
        MIT,
        NovBalgarskiUniversitet
    }

    enum Faculty
    {
        KSS,
        MII,
        PM,
    }

}
