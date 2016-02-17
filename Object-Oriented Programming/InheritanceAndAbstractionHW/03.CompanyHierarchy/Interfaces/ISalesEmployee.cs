using System.Collections;
using System.Collections.Generic;
using CompanyHierarchy.Products;

namespace CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee
    {
        List<Sales> Sales { get; }
        void AddSale(Sales sale);
    }
}