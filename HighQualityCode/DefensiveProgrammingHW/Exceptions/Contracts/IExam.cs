namespace Exceptions.Contracts
{
    using Models.Exams;

    public interface IExam
    {
        ExamResult Check();
    }
}