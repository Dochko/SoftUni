namespace CohesionAndCoupling.Contracts
{
    /// <summary>
    /// The Shape Interface which describes a box.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Gets or sets the width of the box.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        double Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the box.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        double Height { get; set; }

        /// <summary>
        /// Gets or sets the depth of the box.
        /// </summary>
        /// <value>
        /// The depth.
        /// </value>
        double Depth { get; set; }

        /// <summary>
        /// Calculates the volume.
        /// </summary>
        /// <returns>Returns the calculated volume of the box.</returns>
        double CalcVolume();
    }
}