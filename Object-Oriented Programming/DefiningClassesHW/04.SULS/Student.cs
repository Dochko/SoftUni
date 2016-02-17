namespace SULS
{
    public abstract class Student : Person
    {
        public Student(string firstName, string lastName, int age, string studentNumber, decimal avrgGrade)
            : base(firstName, lastName, age)
        {
            StudentNumber = studentNumber;
            AverageGrade = avrgGrade;
        }

        public string StudentNumber { get; set; }
        public decimal AverageGrade { get; set; }
    }
}
