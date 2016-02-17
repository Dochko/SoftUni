namespace Exceptions.Models.Exams
{
    using Contracts;

    public abstract class Exam : IExam
    {
        public abstract ExamResult Check();
    }
}
