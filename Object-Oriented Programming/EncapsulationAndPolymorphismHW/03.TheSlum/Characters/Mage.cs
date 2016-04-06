namespace TheSlum
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TheSlum.Interfaces;

    #endregion

    public class Mage : Character, IAttack
    {
        private const int AttackPointsDefault = 300;

        private const int DeffencePointsDefault = 50;

        private const int HealhtPointsDefault = 150;

        private const int RangeDefault = 5;

        private int attackPoints;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, HealhtPointsDefault, DeffencePointsDefault, team, RangeDefault)
        {
            this.AttackPoints = AttackPointsDefault;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Attack points of Mage cannot be 0 or negative");
                }

                this.attackPoints = value;
            }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);

            this.ApplyItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var mageList = targetsList.Reverse();

            foreach (var character in mageList)
            {
                if (character.Team != this.Team && character.IsAlive)
                {
                    return character;
                }
            }

            return null;
        }

        public override void RemoveFromInventory(Item item)
        {
            this.RemoveItemEffects(item);

            this.Inventory.Remove(item);
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.attackPoints;
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }
    }
}