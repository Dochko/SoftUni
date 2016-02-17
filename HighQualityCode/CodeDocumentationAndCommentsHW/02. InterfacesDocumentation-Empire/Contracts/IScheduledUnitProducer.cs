namespace Empire.Contracts
{
    /// <summary>
    /// The ScheduledUnitProducer Interface.
    /// </summary>
    /// <seealso cref="Empire.Contracts.IUnitProducer" />
    public interface IScheduledUnitProducer : IUnitProducer
    {
        /// <summary>
        /// Gets a value indicating whether this instance can produce unit.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance can produce unit; otherwise, <c>false</c>.
        /// </value>
        bool CanProduceUnit { get; }
    }
}