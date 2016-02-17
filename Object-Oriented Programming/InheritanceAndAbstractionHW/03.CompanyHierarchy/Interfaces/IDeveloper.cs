using System.Collections.Generic;
using CompanyHierarchy.Products;

namespace CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        List<Projects> Projects { get; }
        void AddProject(Projects project);
    }
}