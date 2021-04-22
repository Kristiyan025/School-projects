using System;
using System.Globalization;

namespace P08
{
    class Program
    {
        private static CultureInfo ci = new CultureInfo("en-US");

        public static string Format(DateTime d)
           => d.ToString("dd MMM yyyy", ci);

        static void Main(string[] args)
        {
            for(int i = 1; i <= 12; i++)
            {
                DateTime d = new DateTime(2021, i, 23);
                Console.WriteLine(Format(d));
            }
        }
    }
}
