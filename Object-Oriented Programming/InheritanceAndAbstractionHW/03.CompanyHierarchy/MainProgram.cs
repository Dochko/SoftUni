using System;
using System.Collections.Generic;
using CompanyHierarchy.Interfaces;
using CompanyHierarchy.Persons;
using CompanyHierarchy.Products;
using CompanyHierarchy.Persons.Employees;

namespace CompanyHierarchy
{
    class MainProgram
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();

            SalesEmployee todor = new SalesEmployee(123, "Todor", "Todorov", 3000m, Departments.Sales);
            todor.AddSale(new Sales("Windows XP SP3", new DateTime(2007, 07, 12), 400m));
            todor.AddSale(new Sales("NOD 32 8.01", new DateTime(2007, 08, 08), 150m));
            persons.Add(todor);

            SalesEmployee dobri = new SalesEmployee(122, "Dobromir", "Hristov", 3500m, Departments.Sales);
            dobri.AddSale(new Sales("Windows 7 PRO SP1", new DateTime(2009, 04, 16), 450m));
            dobri.AddSale(new Sales("AMD Phenom II X4 3.20 GHz", new DateTime(2010, 12, 24), 200m));
            persons.Add(dobri);

            Developer nedqlko = new Developer(007, "Nedqlko", "Nikolov", 6000m, Departments.Production);
            nedqlko.AddProject(new Projects("Smite", new DateTime(2009, 05, 15), "3rd person MOBA"));
            persons.Add(nedqlko);

            Manager roxana = new Manager(111, "Roxana", "Iliuta", 10000m, Departments.Marketing);
            roxana.AddEmployee(todor);
            roxana.AddEmployee(dobri);
            roxana.AddEmployee(nedqlko);
            persons.Add(roxana);

            Customer richKid = new Customer(999, "Richi", "Rich", 2500m);
            persons.Add(richKid);

            foreach (var person in persons)
            {
                Console.WriteLine(person + Environment.NewLine);
            }
        }
    }
}
