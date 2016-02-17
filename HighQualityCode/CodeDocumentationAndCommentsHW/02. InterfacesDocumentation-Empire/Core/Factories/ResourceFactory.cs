using Empire.Contracts;
using Empire.Enums;
using Empire.Models;

namespace Empire.Core.Factories
{
    public class ResourceFactory : IResourceFactory
    {
        public IResource CreateResource(ResourceType resourceType, int quantity)
        {
            var resource = new Resource(resourceType, quantity);

            return resource;
        }
    }
}