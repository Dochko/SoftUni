using System;
using Empire.Contracts;
using Empire.Models.Units;

namespace Empire.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Archer":
                    return new Archer();
                case "Swordsman":
                    return new Swordsman();
                default:
                    throw new ArgumentException("Unknow unit type.");
            }
        }
    }
}