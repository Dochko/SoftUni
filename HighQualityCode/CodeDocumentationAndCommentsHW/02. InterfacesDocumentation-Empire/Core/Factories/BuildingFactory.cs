using System;
using Empire.Contracts;
using Empire.Models.Buildings;

namespace Empire.Core.Factories
{
    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory)
        {
            switch (buildingType)
            {
                case "archery":
                    return new Archery(unitFactory, resourceFactory);
                case "barracks":
                    return new Barracks(unitFactory, resourceFactory);
                default:
                    throw new ArgumentException("Unknow building type.");
            }
        }
    }
}