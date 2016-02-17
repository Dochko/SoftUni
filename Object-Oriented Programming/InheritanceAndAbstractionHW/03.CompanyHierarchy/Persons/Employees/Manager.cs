using System;
using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Persons.Employees
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employees = new List<Employee>();

        public Manager(int id, string firstName, string lastName, decimal salary, Departments department) : base(id, firstName, lastName, salary, department)
        {

        }

        public List<Employee> Employees 
        {
            get { return new List<Employee>(employees); } 
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString() + Environment.NewLine + FirstName + "'s crew:\n");

            foreach (var employee in Employees)
            {
                str.Append("\n" + employee);
            }

            return str.ToString();
        }
    }
}