using System.Collections;
using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interfaces;
using CompanyHierarchy.Products;

namespace CompanyHierarchy.Persons.Employees
{
    public class SalesEmployee : Employee, ISalesEmployee
    {
        private List<Sales> sales = new List<Sales>();

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Departments department) : base(id, firstName, lastName, salary, department)
        {
            
        }

        public List<Sales> Sales
        {
            get { return new List<Sales>(sales); }
        }

        public void AddSale(Sales sale)
        {
            sales.Add(sale);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString() + "\nProducts Sold:");

            foreach (var sale in Sales)
            {
                str.Append("\n" + sale);
            }
            return str.ToString();
        }
    }
}