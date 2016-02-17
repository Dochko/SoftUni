namespace Empire.Contracts
{
    /// <summary>
    /// The Destroyable Interface. Defines if the object can be destroyed or killed.
    /// </summary>
    public interface IDestroyable
    {
        /// <summary>
        /// Gets the health of an unit.
        /// </summary>
        /// <value>
        /// Health.
        /// </value>
        int Health { get; } 
    }
}