namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    /// <summary>
    /// The Course Class.
    /// </summary>
    /// <seealso cref="InheritanceAndPolymorphism.Contracts.ICourse" />
    public abstract class Course : ICourse
    {
        private readonly IList<string> students;
        private string courseName;
        private string teacherName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="teacherName">Name of the teacher.</param>
        protected Course(string courseName, string teacherName)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.students = new List<string>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("course name", "Course name cannot be null or empty !");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("teacher name", "Teacher name cannot be null or empty !");
                }

                this.teacherName = value;
            }
        }

        public ICollection<string> Students
        {
            get
            {
                return this.students; 
            }
        }

        public override string ToString()
        {
            string str = string.Format("{0} - CourseName: {1}, TeacherName: {2}, Students: {3}",
                this.GetType().Name, this.CourseName, this.TeacherName, this.GetStudentsAsString());

            return str;
        }
        
        /// <summary>
        /// Gets the students as string.
        /// </summary>
        /// <returns>Returns the students as string.</returns>
        private string GetStudentsAsString()
        {
            string str = string.Empty;

            if (this.Students == null || this.Students.Count == 0)
            {
                str = "( No students at the moment. )";

                return str;
            }
            else
            {
                str = "( " + string.Join(", ", this.Students) + " )";

                return str;
            }
        }
    }
}