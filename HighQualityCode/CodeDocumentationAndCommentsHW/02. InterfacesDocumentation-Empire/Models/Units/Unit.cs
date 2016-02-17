using System;
using Empire.Contracts;

namespace Empire.Models.Units
{
    public abstract class Unit : IUnit
    {
        private int attackDamage;
        private int health;

        protected Unit(int attackDamage, int health)
        {
            this.AttackDamage = attackDamage;
            this.InitHealth(health);
        }

        public int AttackDamage
        {
            get
            {
                return this.attackDamage; 
                
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.attackDamage), "Attack damage cannot be negative.");
                }
                this.attackDamage = value;
            }
            
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    this.health = value < 0 ? 0 : value;
                }
            }
        }

        private void InitHealth(int initialHealth)
        {
            if (initialHealth <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialHealth)
                    , "A unit`s initial health should be positive.");
            }
            this.health = initialHealth;
        }
    }
}