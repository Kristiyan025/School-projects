namespace Rational_fraction.Fraction
{
    using System;

    public class Fraction
    {
        private const double EPS = 1e-6;

        public Fraction()
        {
            this.Numerator = 0;
            this.Denominator = 1;
        }

        public Fraction(long integer)
        {
            this.Numerator = integer;
            this.Denominator = 1;
        }

        public Fraction(int integer) : this((long)integer) { }

        public Fraction(short integer) : this((long)integer) { }

        public Fraction(long numerator, long denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("A Fraction's denominator must be non-zero!");
            }

            if (denominator < 0)
            {
                denominator = -denominator;
                numerator = -numerator;
            }

            this.Numerator = numerator;
            this.Denominator = denominator;
            InLowestTerms();
        }

        public Fraction(double fraction) : this()
        {
            this.Numerator = (int)Math.Truncate(fraction);
            fraction -= this.Numerator;
            int counter = 0;
            while(fraction > Fraction.EPS && counter < 6)
            {
                fraction *= 10;
                this.Numerator *= 10;
                this.Denominator *= 10;
                long digit = (long)Math.Truncate(fraction);
                this.Numerator += digit;
                fraction -= digit;
                counter++;
            }

            InLowestTerms();
        }

        public long Numerator { get; private set; }

        public long Denominator { get; private set; }

        public static Fraction operator +(Fraction f) => f;

        public static Fraction operator -(Fraction f) 
            => new Fraction(-f.Numerator, f.Denominator);

        public static Fraction operator +(Fraction f1, Fraction f2)
            => new Fraction(f1.Numerator * f2.Denominator + 
                            f1.Denominator * f2.Numerator, 
                            f1.Denominator * f2.Denominator);

        public static Fraction operator -(Fraction f1, Fraction f2)
            => new Fraction(f1.Numerator * f2.Denominator -
                            f1.Denominator * f2.Numerator,
                            f1.Denominator * f2.Denominator);

        public static Fraction operator *(Fraction f1, Fraction f2)
            => new Fraction(f1.Numerator * f2.Numerator,
                            f1.Denominator * f2.Denominator);

        public static Fraction operator /(Fraction f1, Fraction f2)
            => new Fraction(f1.Numerator * f2.Denominator,
                            f1.Denominator * f2.Numerator);

        public static Fraction operator +(Fraction f, long integer)
            => new Fraction(f.Numerator + integer * f.Denominator, f.Denominator);

        public static Fraction operator +(long integer, Fraction f) => f + integer;

        public static Fraction operator -(Fraction f, long integer)
            => new Fraction(f.Numerator - integer * f.Denominator, f.Denominator);

        public static Fraction operator -(long integer, Fraction f)
            => new Fraction(integer * f.Denominator - f.Numerator, f.Denominator);

        public static Fraction operator *(Fraction f, long integer)
            => new Fraction(f.Numerator * integer, f.Denominator);

        public static Fraction operator *(long integer, Fraction f) => f * integer;

        public static Fraction operator /(Fraction f, long integer)
            => new Fraction(f.Numerator, f.Denominator * integer);

        public static Fraction operator /(long integer, Fraction f)
            => new Fraction(f.Denominator * integer, f.Numerator);

        public static bool operator >(Fraction f1, Fraction f2)
            => f1.Numerator * f2.Denominator > f2.Numerator * f1.Denominator;

        public static bool operator <(Fraction f1, Fraction f2)
            => f1.Numerator * f2.Denominator < f2.Numerator * f1.Denominator;

        public static bool operator ==(Fraction f1, Fraction f2)
            => f1.Numerator == f2.Numerator && f1.Denominator == f2.Denominator;

        public static bool operator !=(Fraction f1, Fraction f2)
            => !(f1 == f2);

        public static Fraction Min(Fraction f1, Fraction f2)
            => f1 < f2 ? f1 : f2;

        public static Fraction Min(Fraction f1, Fraction f2, Fraction f3)
        {
            if(f1 > f2)
            {
                Fraction f = f1;
                f1 = f2;
                f2 = f;
            }
            if (f1 > f3)
            {
                Fraction f = f1;
                f1 = f3;
                f3 = f;
            }

            return f1;
        }

        public static Fraction Min(Fraction[] f)
        {
            if (f.Length == 0) 
                throw new ArgumentNullException("Array should contain at least one fraction!");
            if (f.Length == 1) return f[0];

            Fraction acc = Fraction.Min(f[0], f[1]);
            for(int i = 2; i < f.Length; i++)
            {
                acc = Fraction.Min(acc, f[i]);
            }

            return acc;
        }

        public static Fraction Max(Fraction f1, Fraction f2)
            => f1 > f2 ? f1 : f2;

        public static Fraction Max(Fraction f1, Fraction f2, Fraction f3)
        {
            if (f1 < f2)
            {
                Fraction f = f1;
                f1 = f2;
                f2 = f;
            }
            if (f1 < f3)
            {
                Fraction f = f1;
                f1 = f3;
                f3 = f;
            }

            return f1;
        }

        public static Fraction Max(Fraction[] f)
        {
            if (f.Length == 0)
                throw new ArgumentNullException("Array should contain at least one fraction!");
            if (f.Length == 1) return f[0];

            Fraction acc = Fraction.Max(f[0], f[1]);
            for (int i = 2; i < f.Length; i++)
            {
                acc = Fraction.Max(acc, f[i]);
            }

            return acc;
        }

        public override string ToString()
        {
            return $"Fraction: {this.Numerator} / {this.Denominator}\n" +
                $"Decimal Approximation: {(double)this.Numerator / this.Denominator:F6} (EPS ~ {Fraction.EPS})";
        }

        private static long GCD(long a, long b)
        {
            if (a < 0) a = -a;
            if (b < 0) b = -b;
            while (b != 0)
            {
                long oldB = b;
                b = a % b;
                a = oldB;
            }

            return a;
        }

        private void InLowestTerms()
        {
            long gcd = Fraction.GCD(this.Numerator, this.Denominator);
            this.Numerator /= gcd;
            this.Denominator /= gcd;
        }
    }
}
