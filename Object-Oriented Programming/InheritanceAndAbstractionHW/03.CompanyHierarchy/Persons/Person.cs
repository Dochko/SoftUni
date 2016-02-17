using System;
using System.Runtime.CompilerServices;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Persons
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Id");
                }
                id = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null !");
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
                    throw new ArgumentNullException("Last name cannot be null !");
                }
                lastName = value;
            } 
        }

        public override string ToString()
        {
            string str = string.Format("ID: {0}{3}First Name: {1}{3}Last Name: {2}{3}",
                id, firstName, lastName, Environment.NewLine);
            return str;
        }
    }
}