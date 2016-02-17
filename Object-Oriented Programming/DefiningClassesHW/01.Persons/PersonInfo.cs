using System;

namespace Persons
{
    class PersonInfo
    {
        private string name;
        private int age;
        private string email;

        public PersonInfo()
        {
        }

        public PersonInfo(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public PersonInfo(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
                return name; 
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name is mandatory !");
                }
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty !");
                }
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age; 
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("Age out of range !");
                }
                age = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    value = "No email !";
                }
                else if (!value.Contains("@"))
                {
                    throw new Exception("Not a valid email ! Must contain @");
                }
                email = value;
            }
        }
    
        public override string ToString()
        {
            string output = "Name: " + Name + "\n";
            output += "Age: " + Age + "\n";

            if (!string.IsNullOrWhiteSpace(Email))
            {
                output += "Email: " + Email + "\n";
            }

            return output;
        }
    }
}