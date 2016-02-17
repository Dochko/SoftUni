namespace InheritanceAndPolymorphism.Contracts
{
    /// <summary>
    /// The LocalCourse Interface.
    /// </summary>
    /// <seealso cref="InheritanceAndPolymorphism.Contracts.ICourse" />
    public interface ILocalCourse : ICourse
    {
        /// <summary>
        /// Gets or sets the name of the lab.
        /// </summary>
        /// <value>
        /// The name of the lab.
        /// </value>
        string LabName { get; set; }
    }
}