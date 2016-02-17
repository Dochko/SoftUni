namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using System.Text;
    using Contracts;

    /// <summary>
    /// The LocalCourse Class.
    /// </summary>
    /// <seealso cref="InheritanceAndPolymorphism.Courses.Course" />
    /// <seealso cref="InheritanceAndPolymorphism.Contracts.ILocalCourse" />
    public class LocalCourse : Course, ILocalCourse
    {
        private string labName;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="teacherName">Name of the teacher.</param>
        public LocalCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="teacherName">Name of the teacher.</param>
        /// <param name="labName">Name of the lab.</param>
        public LocalCourse(string courseName, string teacherName, string labName) : base(courseName, teacherName)
        {
            this.LabName = labName;
        }

        public string LabName
        {
            get
            {
                return this.labName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("lab name", "Lab name cannot be null or empty");
                }

                this.labName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.LabName != null)
            {
                result.AppendLine(base.ToString() + ", LabName: " + this.LabName);
            }
            else
            {
                result.AppendLine(base.ToString());
            }

            return result.ToString();
        }
    }
}