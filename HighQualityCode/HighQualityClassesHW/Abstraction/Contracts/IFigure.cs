namespace Abstraction.Contracts
{
    /// <summary>
    /// The Figure Interface.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Calculates the perimeter of a figure.
        /// </summary>
        /// <returns>Returns the calculated perimeter of a figure</returns>
        double CalcPerimeter();

        /// <summary>
        /// Calculates the surface of a figure.
        /// </summary>
        /// <returns>Returns the calculated surface of a figure</returns>
        double CalcSurface();
    }
}