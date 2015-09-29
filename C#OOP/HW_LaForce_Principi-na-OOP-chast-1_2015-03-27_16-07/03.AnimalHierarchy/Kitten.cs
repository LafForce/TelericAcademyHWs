namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(int age, string name)
            : base(age, name)
        {
            Gender Gender = Gender.Female;
        }
    }
}
