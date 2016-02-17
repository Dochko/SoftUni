namespace Exceptions.Contracts
{
    using System.Collections.Generic;
    using Models.Exams;

    public interface IStudent
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        IList<Exam> Exams { get; }

        double CalcAverageExamResultInPercents();
    }
}