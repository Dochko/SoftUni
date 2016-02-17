using System.Security.Cryptography.X509Certificates;

namespace CompanyHierarchy.Interfaces
{
    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}