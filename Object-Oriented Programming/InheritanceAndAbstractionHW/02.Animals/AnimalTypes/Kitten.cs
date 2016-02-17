using System;

namespace Animals.AnimalTypes
{
    public class Kitten : Cat, ISoundProducible
    {
        public Kitten(string name, int age) : base(name, age, "female")
        {
            
        }

        public string ProduceSound()
        {
            string str = string.Format("{0} the {1} said \"Meow !\".", Name, GetType().Name);
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