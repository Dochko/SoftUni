namespace TheSlum
{
    public class Shield : Item
    {
        private const int AttackEffectDefault = 0;

        private const int DeffenceEffectDefault = 50;

        private const int HealthEffectDefault = 0;

        public Shield(string id)
            : base(id, HealthEffectDefault, DeffenceEffectDefault, AttackEffectDefault)
        {
        }
    }
}