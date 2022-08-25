using System;

namespace AccediaTest
{
    class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator must not be zero.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction operator -(Fraction fraction)
        {
            return GetSimplifiedFraction(new Fraction(-fraction.numerator, fraction.denominator)); ;
        }

        public static Fraction operator +(Fraction fraction)
        {
            return fraction;
        }

        public static Fraction operator +(Fraction one, Fraction two)
        {
            Fraction resultFraction = new Fraction(one.numerator * two.denominator + two.numerator * one.denominator, one.denominator * two.denominator);

            return GetSimplifiedFraction(resultFraction);
        }

        public static Fraction operator -(Fraction one, Fraction two)
        {
            return new Fraction((one.numerator * two.denominator) - (two.numerator * one.denominator), one.denominator * two.denominator);
        }

        public static Fraction operator *(Fraction one, Fraction two)
        {
            return new Fraction(one.numerator * two.numerator, one.denominator * two.denominator);
        }

        public static Fraction operator /(Fraction one, Fraction two)
        {
            if (two.numerator == 0)
            {
                throw new DivideByZeroException();
            }

            return GetSimplifiedFraction(new Fraction(one.numerator * two.denominator, one.denominator * two.numerator));
        }

        public static Fraction operator !(Fraction fraction)
        {
            return new Fraction(fraction.denominator, fraction.numerator);
        }

        public static bool operator ==(Fraction one, Fraction two)
        {
            return (one.numerator == two.numerator) && (one.denominator == two.denominator);
        }

        public static bool operator !=(Fraction one, Fraction two)
        {
            return !((one.numerator == two.numerator) && (one.denominator == two.denominator));
        }

        public override bool Equals(object other)
        {
            if (!(other is Fraction)) return false;

            Fraction fraction = (Fraction)other;
            fraction = GetSimplifiedFraction(fraction);
            return this.numerator == fraction.numerator && this.denominator == fraction.denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }

        public override string ToString()
        {
            int greatestCommonDivisor;
            var a = Math.Abs(numerator);
            var b = Math.Abs(denominator);
            greatestCommonDivisor = GetGreatestCommonDevisor(a, b);
            var f = a / greatestCommonDivisor;
            var s = b / greatestCommonDivisor;

            string result = "";
            if (numerator < 0 && denominator < 0)
                result = $"{f} / {s}";
            else if (numerator > 0 && denominator < 0)
                result = $"-{f} / {s}";
            else
                result = $"{f} / {s}";

            return result;
        }

        private static int GetGreatestCommonDevisor(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        private static Fraction GetSimplifiedFraction(Fraction fraction)
        {
            int numerator = fraction.numerator;
            int denominator = fraction.denominator;
            int greatestCommonDevisor = GetGreatestCommonDevisor(numerator, denominator);

            if (greatestCommonDevisor != 0)
            {
                numerator /= greatestCommonDevisor;
                denominator /= greatestCommonDevisor;
            }

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            return new Fraction(numerator, denominator);
        }
    }
}
