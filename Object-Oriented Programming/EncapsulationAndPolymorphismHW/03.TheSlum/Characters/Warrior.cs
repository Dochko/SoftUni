using System;
using System.Collections.Generic;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Warrior : Character, IAttack
    {
        private int attackPoints;

        private const int AttackPointsDefault = 150;
        private const int HealhtPointsDefault = 200;
        private const int DeffencePointsDefault = 100;
        private const int RangeDefault = 2;

        public Warrior(string id, int x, int y, Team team)
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
                    throw new ArgumentOutOfRangeException("Attack points of Warrior cannot be 0 or negative");
                }
                attackPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            foreach (var character in targetsList)
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
            Inventory.Remove(item);

            RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + attackPoints;

        }
    }
}