using System;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public long Numerator
        {
            get { return numerator; }
            private set { numerator = value; } 
        }

        public long Denominator
        {
            get { return denominator; }
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("denominator", "Denominator cannot be zero !");
                }
                denominator = value;
            }
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            left.Numerator *= right.Denominator;
            right.Numerator *= left.Denominator;

            long commonDenomirator = left.Denominator*right.Denominator;

            return new Fraction(left.Numerator + right.Numerator, commonDenomirator);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            left.Numerator *= right.Denominator;
            right.Numerator *= left.Denominator;

            long commonDenomirator = left.Denominator * right.Denominator;

            return new Fraction(left.Numerator - right.Numerator, commonDenomirator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal) Numerator / Denominator);
        }
    }
}