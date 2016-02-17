namespace TheSlum
{
    using System.Collections.Generic;

    public abstract class Character : GameObject
    {
        protected Character(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id)
        {
            HealthPoints = healthPoints;
            DefensePoints = defensePoints;
            Team = team;
            IsAlive = true;
            X = x;
            Y = y;
            Inventory = new List<Item>();
            Range = range;
        }

        public int HealthPoints { get; set; }

        public int DefensePoints { get; set; }

        public Team Team { get; }

        public List<Item> Inventory { get; private set; }

        public int Range { get; set; }

        public bool IsAlive { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public abstract Character GetTarget(IEnumerable<Character> targetsList);

        public abstract void AddToInventory(Item item);

        public abstract void RemoveFromInventory(Item item);

        protected virtual void ApplyItemEffects(Item item)
        {
            HealthPoints += item.HealthEffect;
            DefensePoints += item.DefenseEffect;
        }

        protected virtual void RemoveItemEffects(Item item)
        {
            HealthPoints -= item.HealthEffect;
            DefensePoints -= item.DefenseEffect;
            if (HealthPoints < 0)
            {
                HealthPoints = 1;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Name: {0}, Team: {2}, Health: {1}, Defense: {3}",
                Id,
                HealthPoints,
                Team,
                DefensePoints);
        }
    }
}