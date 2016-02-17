namespace SULS
{
    public abstract class Current : Student
    {
        public Current(string firstName, string lastName, int age, string studentNumber, decimal avrgGrade, string currentCourse) 
            : base(firstName, lastName, age, studentNumber, avrgGrade)
        {
            CurrentCourse = currentCourse;
        }

        public string CurrentCourse { get; set; }
    }
}
