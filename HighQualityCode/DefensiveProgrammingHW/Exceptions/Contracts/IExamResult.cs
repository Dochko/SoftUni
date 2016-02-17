namespace Exceptions.Contracts
{
    public interface IExamResult
    {
        int Grade { get; }

        int MinGrade { get; }

        int MaxGrade { get; }

        string Comments { get; }
    }
}