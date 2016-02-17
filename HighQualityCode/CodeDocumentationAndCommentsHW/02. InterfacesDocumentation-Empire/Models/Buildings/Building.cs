using System;
using Empire.Contracts;
using Empire.Enums;

namespace Empire.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private const int ProductionDelay = 1;

        private int cyclesCount = 0;

        private readonly string unitType;
        private int unitCycleLength;
        private readonly ResourceType resourceType;
        private int resourceCycleLength;
        private int resourceQuantity;
        private readonly IUnitFactory unitFactory;
        private readonly IResourceFactory resourceFactory;

        protected Building(
            string unitType,
            int unitCycleLength,
            ResourceType resourceType,
            int resourceCycleLength,
            int resourceQuantity,
            IUnitFactory unitFactory,
            IResourceFactory resourceFactory)
        {
            this.unitType = unitType;
            this.UnitCycleLength = unitCycleLength;
            this.resourceType = resourceType;
            this.ResourceCycleLength = resourceCycleLength;
            this.ResourceQuantity = resourceQuantity;
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
        }

        private int UnitCycleLength
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.unitCycleLength), 
                        "The length of the production cycle for units should be positive.");
                }
                this.unitCycleLength = value;
            }
            
        }

        private int ResourceCycleLength
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.resourceCycleLength),
                        "The length of the production cycle for resources should be positive.");
                }
                this.resourceCycleLength = value;
            }
        }

        private int ResourceQuantity
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.resourceQuantity),
                        "The resource quantity produced by the building cannot be negative.");
                }
                this.resourceQuantity = value;
            }
        }

        public bool CanProduceResource
        {
            get
            {
                bool canProduceResource = this.cyclesCount > ProductionDelay 
                    && (this.cyclesCount - ProductionDelay) % this.resourceCycleLength == 0;

                return canProduceResource;
            }
            
        }

        public bool CanProduceUnit
        {
            get
            {
                bool canProduceUnit = this.cyclesCount > ProductionDelay
                    && (this.cyclesCount - ProductionDelay)%this.unitCycleLength == 0;

                return canProduceUnit;
            }
            
        }

        public IResource ProduceResource()
        {
            var resource = this.resourceFactory.CreateResource(this.resourceType, this.resourceQuantity);

            return resource;
        }

        public IUnit ProduceUnit()
        {
            var unit = this.unitFactory.CreateUnit(this.unitType);

            return unit;
        }

        public virtual void Update()
        {
            this.cyclesCount++;
        }

        public override string ToString()
        {
            int turnsUntilUnits = this.unitCycleLength - (this.cyclesCount - ProductionDelay) % this.unitCycleLength;
            int turnsUntilResource = this.resourceCycleLength - (this.cyclesCount - ProductionDelay) % this.resourceCycleLength;

            var result = string.Format("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name, 
                this.cyclesCount - ProductionDelay, 
                turnsUntilUnits, 
                this.unitType, 
                turnsUntilResource, 
                this.resourceType);

            return result;
        }
    }
}