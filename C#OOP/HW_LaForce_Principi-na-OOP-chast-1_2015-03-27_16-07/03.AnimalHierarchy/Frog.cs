namespace AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(int age, string name, Gender gender)
            : base(age, name, gender)
        {
            this.Type = Type.Frog;
        }

        public override string MakeSound()
        {
            return string.Format("{0} {1} Quarckkk", this.Type, this.Name);
        }
    }
}
