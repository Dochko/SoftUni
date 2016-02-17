namespace InheritanceAndPolymorphism.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// The Course Interface.
    /// </summary>
    public interface ICourse
    {
        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        /// <value>
        /// The name of the course.
        /// </value>
        string CourseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the teacher.
        /// </summary>
        /// <value>
        /// The name of the teacher.
        /// </value>
        string TeacherName { get; set; }

        /// <summary>
        /// Gets a ICollection of Students.
        /// </summary>
        /// <value>
        /// The students.
        /// </value>
        ICollection<string> Students { get; }
    }
}