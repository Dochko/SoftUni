namespace Methods.Contracts
{
    using System;

    /// <summary>
    /// The Student Interface.
    /// </summary>
    public interface IStudent
    {
        /// <summary>
        /// Gets or sets the first name of a student.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of a student.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the additional information of a student.
        /// </summary>
        /// <value>
        /// The additional information.
        /// </value>
        string AdditionalInfo { get; set; }

        /// <summary>
        /// Determines whether the student is older than the other student.
        /// </summary>
        /// <param name="other">The other student.</param>
        /// <returns>If yes - true, otherwise false.</returns>
        bool IsOlderThan(IStudent other);

        /// <summary>
        /// Gets the birthday from the additional info of a student.
        /// </summary>
        /// <param name="input">The additional info of a student.</param>
        /// <returns>The student's birthday parsed to DateTime.</returns>
        DateTime GetBirthday(string input);
    }
}