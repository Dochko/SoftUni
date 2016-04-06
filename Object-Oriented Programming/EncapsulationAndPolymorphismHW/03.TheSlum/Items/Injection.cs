namespace TheSlum
{
    public class Injection : Bonus
    {
        private const int AttackEffectDefault = 0;

        private const int DeffenceEffectDefault = 0;

        private const int HealthEffectDefault = 200;

        private const int LifeOfItem = 3;

        public Injection(string id)
            : base(id, HealthEffectDefault, DeffenceEffectDefault, AttackEffectDefault)
        {
            this.Countdown = LifeOfItem;
        }
    }
}