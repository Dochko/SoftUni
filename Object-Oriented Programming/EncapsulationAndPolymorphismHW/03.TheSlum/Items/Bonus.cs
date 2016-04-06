namespace TheSlum
{
    #region

    using TheSlum.Interfaces;

    #endregion

    public abstract class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
        }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }

        public int Timeout { get; set; }
    }
}