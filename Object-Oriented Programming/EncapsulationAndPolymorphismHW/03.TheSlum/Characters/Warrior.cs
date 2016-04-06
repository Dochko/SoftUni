namespace TheSlum
{
    #region

    using System;
    using System.Collections.Generic;

    using TheSlum.Interfaces;

    #endregion

    public class Warrior : Character, IAttack
    {
        private const int AttackPointsDefault = 150;

        private const int DeffencePointsDefault = 100;

        private const int HealhtPointsDefault = 200;

        private const int RangeDefault = 2;

        private int attackPoints;

        public Warrior(string id, int x, int y, Team team)
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
                    throw new ArgumentOutOfRangeException("Attack points of Warrior cannot be 0 or negative");
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
            foreach (var character in targetsList)
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
            this.Inventory.Remove(item);

            this.RemoveItemEffects(item);
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