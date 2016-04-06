namespace TheSlum
{
    public class Pill : Bonus
    {
        private const int AttackEffectDefault = 100;

        private const int DeffenceEffectDefault = 0;

        private const int HealthEffectDefault = 0;

        private const int LifeOfItem = 1;

        public Pill(string id)
            : base(id, HealthEffectDefault, DeffenceEffectDefault, AttackEffectDefault)
        {
            this.Countdown = LifeOfItem;
        }
    }
}