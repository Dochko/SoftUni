namespace Abstraction.Contracts
{
    /// <summary>
    /// The Circle Interface.
    /// </summary>
    /// <seealso cref="Abstraction.Contracts.IFigure" />
    public interface ICircle : IFigure
    {
        /// <summary>
        /// Gets or sets the radius of a circle.
        /// </summary>
        /// <value>
        /// The radius.
        /// </value>
        double Radius { get; set; }
    }
}