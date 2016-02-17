using System.Collections.Generic;
using Empire.Enums;

namespace Empire.Contracts
{
    /// <summary>
    /// The EmpiresData Interface.
    /// </summary>
    public interface IEmpiresData
    {
        /// <summary>
        /// Gets the buildings.
        /// </summary>
        /// <value>
        /// Buildings.
        /// </value>
        IEnumerable<IBuilding> Buildings { get; }

        /// <summary>
        /// Adds the building.
        /// </summary>
        /// <param name="building">The building.</param>
        void AddBuilding(IBuilding building);

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <value>
        /// Units.
        /// </value>
        IDictionary<string, int> Units  { get; }

        /// <summary>
        /// Adds the unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        void AddUnit(IUnit unit);

        /// <summary>
        /// Gets the resources.
        /// </summary>
        /// <value>
        /// Resources.
        /// </value>
        IDictionary<ResourceType, int> Resources { get; }
    }
}