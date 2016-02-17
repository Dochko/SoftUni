namespace Methods.Models
{
    using System;
    using System.Linq;
    using Contracts;

    /// <summary>
    /// The Student Class.
    /// </summary>
    /// <seealso cref="Methods.Contracts.IStudent" />
    public class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private string additionalInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="additionalInfo">The additional information.</param>
        public Student(string firstName, string lastName, string additionalInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AdditionalInfo = additionalInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName; 
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("first name", "First name cannot be null or empty !");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get 
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("last name", "Last name cannot be null or empty !");
                }

                this.lastName = value;
            }
        }

        public string AdditionalInfo
        {
            get
            {
                return this.additionalInfo;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("additional info", "Additional info cannot be null or empty !");
                }

                this.additionalInfo = value;
            }
        }

        public bool IsOlderThan(IStudent other)
        {
            try
            {
                DateTime firstStudentBirthday = this.GetBirthday(this.AdditionalInfo);
                DateTime secondStudentBirthday = other.GetBirthday(other.AdditionalInfo);

                return firstStudentBirthday < secondStudentBirthday;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new ArgumentException("One or both students do not have valid date of birth information provided.");
            }
        }

        public DateTime GetBirthday(string input)
        {
            string[] paramsArgs = input.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            string date = paramsArgs.Last().Substring(8).Trim();
            DateTime birthday = DateTime.Parse(date);

            return birthday;
        }
    }
}