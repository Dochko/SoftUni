using System;
using System.Text;

namespace SULS
{
    public class Dropout : Student
    {
        public Dropout(string firstName, string lastName, int age, string studentNumber, string dropoutReason, decimal avrgGrade) 
            : base(firstName, lastName, age, studentNumber, avrgGrade)
        {
            DropoutReason = dropoutReason;
        }

        public string DropoutReason { get; set; }

        public void Reapply()
        {
            StringBuilder output = new StringBuilder();

            output.Append("Name: " + FirstName + " " + LastName + "  Age: " + Age + "  ID: " + StudentNumber);
            output.Append("\nDropout reason: " + DropoutReason);

            Console.WriteLine(output);
        }
    }
}
