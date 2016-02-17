using System.Collections;
using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interfaces;
using CompanyHierarchy.Products;

namespace CompanyHierarchy.Persons.Employees
{
    public class Developer : Employee, IDeveloper
    {
        private List<Projects> projects = new List<Projects>();

        public Developer(int id, string firstName, string lastName, decimal salary, Departments department) : base(id, firstName, lastName, salary, department)
        {
            
        }

        public List<Projects> Projects
        {
            get { return new List<Projects>(projects); }
        }

        public void AddProject(Projects project)
        {
            projects.Add(project);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString() + "\nProjects developed/in development:");
            foreach (var project in Projects)
            {
                str.Append("\n" + project);
            }
            return str.ToString();
        }
    }
}