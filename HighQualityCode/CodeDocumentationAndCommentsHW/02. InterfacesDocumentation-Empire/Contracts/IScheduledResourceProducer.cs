namespace Empire.Contracts
{
    /// <summary>
    /// The ScheduleResourceProducer Interface.
    /// </summary>
    /// <seealso cref="Empire.Contracts.IResourceProducer" />
    public interface IScheduledResourceProducer : IResourceProducer
    {
        /// <summary>
        /// Gets a value indicating whether this instance can produce resource.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance can produce resource; otherwise, <c>false</c>.
        /// </value>
        bool CanProduceResource { get; }
    }
}