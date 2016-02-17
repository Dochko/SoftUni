namespace Abstraction.Contracts
{
    /// <summary>
    /// The Rectangle Interface.
    /// </summary>
    /// <seealso cref="Abstraction.Contracts.IFigure" />
    public interface IRectangle : IFigure
    {
        /// <summary>
        /// Gets or sets the width of an rectangle.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        double Width { get; set; }

        /// <summary>
        /// Gets or sets the height of an rectangle.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        double Height { get; set; }
    }
}