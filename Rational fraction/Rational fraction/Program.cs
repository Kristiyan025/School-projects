namespace Rational_fraction
{
    using System;
    using F = Fraction;

    public class Program
    {
        public static void Main(string[] args)
        {
            F.Fraction f1, f2, f3;
            ReadFraction(out f1);
            Console.WriteLine("The next fraction shouldn't be zero (for the division)!");
            ReadFraction(out f2);
            Console.WriteLine($"The sum: {f1 + f2}");
            Console.WriteLine($"The difference: {f1 - f2}");
            Console.WriteLine($"The product: {f1 * f2}");
            Console.WriteLine($"The division: {f1 / f2}");

            ReadFraction(out f1);
            ReadFraction(out f2);
            ReadFraction(out f3);

            Console.WriteLine($"The Minimum: {F.Fraction.Min(f1, f2, f3)}");
            Console.WriteLine();
            Console.WriteLine();

            ///This I have done the last time and didn't finish it
            /// It just tests the constructors, not the whole functionality
            /// For the test to succeed, the decimal separator on your computer should be '.', not ','
            F.FractionTester.TestClass();
        }

        private static void ReadFraction(out F.Fraction f)
        {
            Console.WriteLine("Enter the fraction's numerator: ");
            long numerator = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fraction's denominator (it can't be zero): ");
            long denominator = long.Parse(Console.ReadLine());

            f =  new F.Fraction(numerator, denominator);
        }
    }
}
