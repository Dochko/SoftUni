namespace SULS
{
    class Onsite : Current
    {
        public Onsite(string firstName, string lastName, int age, string studentNumber, decimal avrgGrade, string currentCourse, int visits = 0)
            : base(firstName, lastName, age, studentNumber, avrgGrade, currentCourse)
        {
            NumberOfVisits = visits;
        }

        public int NumberOfVisits { get; set; }
    }
}
