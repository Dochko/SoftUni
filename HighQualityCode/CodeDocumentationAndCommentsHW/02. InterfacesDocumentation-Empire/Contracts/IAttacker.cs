namespace Empire.Contracts
{
    /// <summary>
    /// The Attacker Interface. Defines whether the unit has the ability to attack.
    /// </summary>
    public interface IAttacker
    {
         int AttackDamage { get; }
    }
}