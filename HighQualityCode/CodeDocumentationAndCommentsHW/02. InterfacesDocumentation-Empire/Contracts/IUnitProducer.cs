namespace Empire.Contracts
{
    /// <summary>
    /// The UnitProducer Interface.
    /// </summary>
    public interface IUnitProducer
    {
        /// <summary>
        /// Produces the unit.
        /// </summary>
        /// <returns></returns>
        IUnit ProduceUnit();
    }
}