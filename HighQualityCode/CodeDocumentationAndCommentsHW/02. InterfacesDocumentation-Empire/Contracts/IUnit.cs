namespace Empire.Contracts
{
    /// <summary>
    /// The Unit Interface
    /// </summary>
    /// <seealso cref="Empire.Contracts.IAttacker" />
    /// <seealso cref="Empire.Contracts.IDestroyable" />
    public interface IUnit : IAttacker, IDestroyable
    {
         
    }
}