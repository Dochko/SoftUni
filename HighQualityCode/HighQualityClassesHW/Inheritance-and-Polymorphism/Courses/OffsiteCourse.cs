namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using System.Text;
    using Contracts;

    /// <summary>
    /// The OffsiteCourse Class.
    /// </summary>
    /// <seealso cref="InheritanceAndPolymorphism.Courses.Course" />
    /// <seealso cref="InheritanceAndPolymorphism.Contracts.IOffsiteCourse" />
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string townName;

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="teacherName">Name of the teacher.</param>
        public OffsiteCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="teacherName">Name of the teacher.</param>
        /// <param name="townName">Name of the town.</param>
        public OffsiteCourse(string courseName, string teacherName, string townName) : base(courseName, teacherName)
        {
            this.TownName = townName;
        }

        public string TownName
        {
            get
            {
                return this.townName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("town name", "Town name cannot be null or empty");
                }

                this.townName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.TownName != null)
            {
                result.AppendLine(base.ToString() + ", TownName: " + this.TownName);
            }
            else
            {
                result.AppendLine(base.ToString());
            }

            return result.ToString();
        }
    }
}