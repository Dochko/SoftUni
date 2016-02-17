using Empire.Enums;

namespace Empire.Contracts
{
    /// <summary>
    /// THe Resource Interface.
    /// </summary>
    public interface IResource
    {
        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        /// <value>
        /// The type of the resource.
        /// </value>
        ResourceType ResourceType { get; }

        /// <summary>
        /// Gets the quantity of resources.
        /// </summary>
        /// <value>
        /// The quantity of resources.
        /// </value>
        int Quantity { get; }
    }
}