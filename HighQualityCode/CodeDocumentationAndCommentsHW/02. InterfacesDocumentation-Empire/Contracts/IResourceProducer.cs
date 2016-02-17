namespace Empire.Contracts
{
    /// <summary>
    /// The ResourceProducer Interface.
    /// </summary>
    public interface IResourceProducer
    {
        /// <summary>
        /// Produces the resource.
        /// </summary>
        /// <returns></returns>
        IResource ProduceResource();
    }
}