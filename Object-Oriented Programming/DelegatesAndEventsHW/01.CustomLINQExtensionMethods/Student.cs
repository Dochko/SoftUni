using System;

namespace CustomLINQExtensionMethods
{
    public class Student
    {
        private string name;
        private int grade;

        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("student name", "Name cannot be null or empty !");
                }
                this.name = value;
            } 
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("student grade", "Grade cannot be 0 or negative !");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Grade: {1}", Name, Grade);
        }
    }
}