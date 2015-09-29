namespace AnimalHierarchy
{
    using System;

    class Dog : Animal
    {
        public Dog(int age, string name, Gender gender)
            : base(age, name, gender)
        {
            this.Type = Type.Dog;
        }

        public override string MakeSound()
        {
            return string.Format("{0} {1} - Bau Waw", this.Type, this.Name);
        }
    }
}
