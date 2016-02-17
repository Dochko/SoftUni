using Empire.Enums;

namespace Empire.Contracts
{
    /// <summary>
    /// The ResourceFactory Interface.
    /// </summary>
    public interface IResourceFactory
    {
        /// <summary>
        /// Creates the resource.
        /// </summary>
        /// <param name="resourceType">Type of the resource.</param>
        /// <param name="quantity">The quantity.</param>
        /// <returns></returns>
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}