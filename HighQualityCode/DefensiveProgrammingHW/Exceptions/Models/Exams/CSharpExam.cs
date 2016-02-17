namespace Exceptions.Models.Exams
{
    using System;
    using Contracts;

    public class CSharpExam : Exam, ICSharpExam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;

        private int score;

        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new NullReferenceException();
            }

            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinScore || value > MaxScore)
                {
                    throw new ArgumentOutOfRangeException("score", string.Format("The score can be in range of {0} ... {1}.", MinScore, MaxScore));
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");    
        }
    }
}
