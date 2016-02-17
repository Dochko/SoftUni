using System;

namespace HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Faculty number cannot be empty and must be in range of [5 ... 10] !");
                }
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("{0}{2}Faculty Number: {1}{2}", base.ToString(), facultyNumber, Environment.NewLine);
            return str;
        }
    }
}