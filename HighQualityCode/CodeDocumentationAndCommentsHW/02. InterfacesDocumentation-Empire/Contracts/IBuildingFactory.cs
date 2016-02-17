namespace Empire.Contracts
{
    /// <summary>
    /// The BuildingFactory
    /// </summary>
    public interface IBuildingFactory
    {
        /// <summary>
        /// Creates the building.
        /// </summary>
        /// <param name="buildingType">Type of the building.</param>
        /// <param name="unitFactory">The unit factory.</param>
        /// <param name="resourceFactory">The resource factory.</param>
        /// <returns></returns>
        IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory);
    }
}