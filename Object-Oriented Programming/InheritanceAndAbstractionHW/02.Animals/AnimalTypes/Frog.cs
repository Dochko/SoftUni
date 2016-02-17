using System;

namespace Animals.AnimalTypes
{
    public class Frog : Animal, ISoundProducible
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public string ProduceSound()
        {
            string str = string.Format("{0} the {1} said \"Croak !\"", Name, GetType().Name);
            return str;
        }

        public override string ToString()
        {
            string str = string.Format("{0}{1}{2}",
                base.ToString(), ProduceSound(), Environment.NewLine);

            return str;
        }
    }
}