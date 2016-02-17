using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Mage : Character, IAttack
    {
        private int attackPoints;

        private const int AttackPointsDefault = 300;
        private const int HealhtPointsDefault = 150;
        private const int DeffencePointsDefault = 50;
        private const int RangeDefault = 5;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, HealhtPointsDefault, DeffencePointsDefault, team, RangeDefault)
        {
            AttackPoints = AttackPointsDefault;
        }

        public int AttackPoints
        {
            get { return attackPoints; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Attack points of Mage cannot be 0 or negative");
                }
                attackPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var mageList = targetsList.Reverse();

            foreach (var character in mageList)
            {
                if (character.Team != Team && character.IsAlive)
                {
                    return character;
                }
            }
            return null;
        }

        protected override void ApplyItemEffects(Item item)
        {
            AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override void AddToInventory(Item item)
        {
            Inventory.Add(item);

            ApplyItemEffects(item);

        }

        public override void RemoveFromInventory(Item item)
        {
            RemoveItemEffects(item);

            Inventory.Remove(item);
        }

        public override string ToString()
        {
            return base.ToString()+", Attack: "+attackPoints;

        }
    }
}