namespace Exceptions.Models.Exams
{
    using System;
    using Contracts;

    public class ExamResult : IExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < this.MinGrade || value > this.MaxGrade)
                {
                    throw new ArgumentOutOfRangeException("grade", string.Format("The grade should be in range of {0} ... {1}", this.MinGrade, this.MaxGrade));
                }
            }            
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("minGrade", "The minimum grade cannot be negative.");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException("maxGrade", "the maximum grade cannot be lower than the minimum grade.");
                }

                this.maxGrade = value;
            } 
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("comments", "The comments cannot be null or empty !");
                }

                this.comments = value;
            } 
        }
    }
}
