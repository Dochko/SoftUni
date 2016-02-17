using System;

namespace HumanStudentAndWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name is mandatory !");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name is mandatory !");
                }
                lastName = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("Type: {0}{3}First Name: {1}{3}Last Name: {2}", GetType().Name, firstName, lastName, Environment.NewLine);

            return str;
        }
    }
}