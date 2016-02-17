namespace Empire.Contracts
{
    /// <summary>
    /// The UnitFactory Interface.
    /// </summary>
    public interface IUnitFactory
    {
        /// <summary>
        /// Creates the unit.
        /// </summary>
        /// <param name="unitType">Type of the unit.</param>
        /// <returns></returns>
        IUnit CreateUnit(string unitType);
    }
}