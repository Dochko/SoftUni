using System;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name is mandatory !");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be zero or negative !");
                }
                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Gender is mandatory !");
                }
                gender = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("{0} is {1}. Its age is {2} and it is {3}.{4}", Name, GetType().Name, Age, Gender, Environment.NewLine);

            return str;
        }
    }
}