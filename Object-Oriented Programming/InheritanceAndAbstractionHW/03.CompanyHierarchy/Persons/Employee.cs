using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Persons
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Departments department;

        public Employee(int id, string firstName, string lastName, decimal salary, Departments department) : base(id, firstName, lastName)
        {
            Salary = salary;
            Department = department;
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative !");
                }
                salary = value;
            } 
            
        }

        public Departments Department
        {
            get { return department; }
            set { department = value; } 
        }

        public override string ToString()
        {
            string str = string.Format(base.ToString() + "Salary: {0}{2}Department: {1}{2}",
                salary, department, Environment.NewLine);
            return str;
        }
    }
}