using System;

namespace Rational_fraction.Fraction
{
    public static class FractionTester
    {
        private static int count, succeeded;

        public static void TestClass()
        {
            FractionTester.TestConstructors();
        }

        private static void PrintTitle(string title)
        {
            int space = 50 + title.Length % 2;
            Console.WriteLine($"#{new string(' ', space)}#");
            Console.WriteLine($"#{new string(' ', (space - title.Length) / 2)}{title}{new string(' ', (space - title.Length) / 2)}#");
            Console.WriteLine($"#{new string(' ', space)}#");
            Console.WriteLine();
        }

        private static void Assert(string test, string value)
        {
            Console.WriteLine(test);
            if(test == value)
            {
                succeeded++;
                Console.WriteLine("Expected result achieved! SUCCESS!");
            }
            else Console.WriteLine("Expected result not achieved! FAILIURE!");
            Console.WriteLine();
        }

        private static void TestConstructors()
        {
            count = 0;
            succeeded = 0;

            PrintTitle("Test Constructors");

            count++;
            Console.WriteLine($"Fraction() =>");
            Fraction f1 = new Fraction();
            Assert(f1.ToString(), "Fraction: 0 / 1\nDecimal Approximation: 0.000000 (EPS ~ 1E-06)");

            count++;
            Console.WriteLine($"Fraction(long integer := 45L) =>");
            Fraction f2 = new Fraction(45L);
            Assert(f2.ToString(), "Fraction: 45 / 1\nDecimal Approximation: 45.000000 (EPS ~ 1E-06)");

            count++;
            Console.WriteLine($"Fraction(int integer := 45) =>");
            Fraction f3 = new Fraction(45);
            Assert(f3.ToString(), "Fraction: 45 / 1\nDecimal Approximation: 45.000000 (EPS ~ 1E-06)");

            count++;
            Console.WriteLine($"Fraction(short integer := (short)45) =>");
            Fraction f4 = new Fraction((short)45);
            Assert(f4.ToString(), "Fraction: 45 / 1\nDecimal Approximation: 45.000000 (EPS ~ 1E-06)");

            count++;
            Console.WriteLine($"Fraction(long numerator := 4L, long denominator := 2L) =>");
            Fraction f5 = new Fraction(4L, 2L);
            Assert(f5.ToString(), "Fraction: 2 / 1\nDecimal Approximation: 2.000000 (EPS ~ 1E-06)");

            count++;
            Console.WriteLine($"Fraction(long numerator := 2L, long denominator := 4L) =>");
            Fraction f6 = new Fraction(2L, 4L);
            Assert(f6.ToString(), "Fraction: 1 / 2\nDecimal Approximation: 0.500000 (EPS ~ 1E-06)");

            count++;
            Console.WriteLine($"Fraction(long numerator := 1L, long denominator := 3L) =>");
            Fraction f7 = new Fraction(1L, 3L);
            Assert(f7.ToString(), "Fraction: 1 / 3\nDecimal Approximation: 0.333333 (EPS ~ 1E-06)");

            string msg = "";
            try
            {
                count++;
                Console.WriteLine($"Fraction(long numerator := 3L, long denominator := 0L) =>");
                Fraction f8 = new Fraction(3L, 0L);
                msg = f8.ToString();
            }
            catch(DivideByZeroException e)
            {
                msg = $"You cannot have fraction 3 / 0. {e.Message}";
            }
            Assert(msg, "You cannot have fraction 3 / 0. A Fraction's denominator must be non-zero!");

            try
            {
                count++;
                Console.WriteLine($"Fraction(long numerator := -3L, long denominator := 0L) =>");
                Fraction f9 = new Fraction(-3L, 0L);
                msg = f9.ToString();
            }
            catch (DivideByZeroException e)
            {
                msg = $"You cannot have fraction -3 / 0. {e.Message}";
            }
            Assert(msg, "You cannot have fraction -3 / 0. A Fraction's denominator must be non-zero!");

            try
            {
                count++;
                Console.WriteLine($"Fraction(long numerator := 3L, long denominator := -0L) =>");
                Fraction f10 = new Fraction(3L, -0L);
                msg = f10.ToString();
            }
            catch (DivideByZeroException e)
            {
                msg = $"You cannot have fraction 3 / -0. {e.Message}";
            }
            Assert(msg, "You cannot have fraction 3 / -0. A Fraction's denominator must be non-zero!");

            count++;
            Console.WriteLine($"Fraction(double fraction := 3.0d) =>");
            Fraction f11 = new Fraction(3.0d);
            Assert(f11.ToString(), "Fraction: 3 / 1\nDecimal Approximation: 3.000000 (EPS ~ 1E-06)");

            count++;
            Console.WriteLine($"Fraction(double fraction := 24.3434d) =>");
            Fraction f12 = new Fraction(24.3434d);
            Assert(f12.ToString(), "Fraction: 24343399 / 1000000\nDecimal Approximation: 24.343399 (EPS ~ 1E-06)");

            count++;
            Console.WriteLine($"Fraction(double fraction := 24.34344645464d) =>");
            Fraction f13 = new Fraction(24.34344645464d);
            Assert(f13.ToString(), "Fraction: 12171723 / 500000\nDecimal Approximation: 24.343446 (EPS ~ 1E-06)");

            Console.WriteLine();
            Console.WriteLine($"Tests: {succeeded} / {count} succeed!");
            Console.WriteLine($"       {count - succeeded} / {count} failed!");
            Console.WriteLine();
        }
    }
}