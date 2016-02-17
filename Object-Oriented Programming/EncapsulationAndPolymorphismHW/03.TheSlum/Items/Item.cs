namespace TheSlum
{
    public abstract class Item : GameObject
    {
        protected Item(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id)
        {
            HealthEffect = healthEffect;
            DefenseEffect = defenseEffect;
            AttackEffect = attackEffect;
        }

        public int HealthEffect { get; set; }

        public int DefenseEffect { get; set; }

        public int AttackEffect { get; set; }
    }
}
