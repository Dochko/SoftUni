using System.Collections.Generic;
using CompanyHierarchy.Persons;

namespace CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        List<Employee> Employees { get;}
        void AddEmployee(Employee emp);
    }
}