namespace InheritanceAndPolymorphism.Contracts
{
    /// <summary>
    /// The OffsiteCourse Interface.
    /// </summary>
    /// <seealso cref="InheritanceAndPolymorphism.Contracts.ICourse" />
    public interface IOffsiteCourse : ICourse
    {
        /// <summary>
        /// Gets or sets the name of the town.
        /// </summary>
        /// <value>
        /// The name of the town.
        /// </value>
        string TownName { get; set; } 
    }
}