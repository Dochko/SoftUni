using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Healer : Character, IHeal
    {
        private int healingPoints;

        private const int HealingPointsDefault = 60;
        private const int HealhtPointsDefault = 75;
        private const int DeffencePointsDefault = 50;
        private const int RangeDefault = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, HealhtPointsDefault, DeffencePointsDefault, team, RangeDefault)
        {
            HealingPoints = HealingPointsDefault;
        }
        public int HealingPoints
        {
            get
            {
                return healingPoints;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Healing points of Healer cannot be 0 or negative");
                }
                healingPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var healerList = targetsList.OrderBy(x => x.HealthPoints);

            foreach (var character in healerList)
            {
                if (character.Team == Team && character.Id != Id && character.IsAlive)
                {
                    return character;
                }
            }
            return null;
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
            return base.ToString() + ", Healing: " + healingPoints;

        }
    }
}