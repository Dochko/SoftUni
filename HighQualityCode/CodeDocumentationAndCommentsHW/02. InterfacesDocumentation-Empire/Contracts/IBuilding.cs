namespace Empire.Contracts
{
    /// <summary>
    /// The Building Interface
    /// </summary>
    /// <seealso cref="Empire.Contracts.IScheduledResourceProducer" />
    /// <seealso cref="Empire.Contracts.IScheduledUnitProducer" />
    /// <seealso cref="Empire.Contracts.IUpdateable" />
    public interface IBuilding 
        : IScheduledResourceProducer, IScheduledUnitProducer, IUpdateable
    {

    }
}