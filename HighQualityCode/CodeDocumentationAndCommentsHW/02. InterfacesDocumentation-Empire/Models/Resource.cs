using System;
using Empire.Contracts;
using Empire.Enums;

namespace Empire.Models
{
    public class Resource : IResource
    {
        private int quantity;

        public Resource(ResourceType resourceType, int quantity)
        {
            this.ResourceType = resourceType;
            this.Quantity = quantity;
        }

        public ResourceType ResourceType { get; }

        public int Quantity
        {
            get
            {
                return this.quantity; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.quantity), "Resource quantity cannot be negative.");
                }
                this.quantity = value;
            }
        }
    }
}