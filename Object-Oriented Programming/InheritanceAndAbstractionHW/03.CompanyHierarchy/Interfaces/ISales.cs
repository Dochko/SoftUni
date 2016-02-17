using System;

namespace CompanyHierarchy.Interfaces
{
    public interface ISales
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}