using System;

namespace P04
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            PrintTrangleLine(0);
        }

        static void PrintTrangleLine(int i)
        {
            if (i == n) return;
            Console.WriteLine($"|{new string(' ', i)}\\");
            PrintTrangleLine(i + 1);
            Console.WriteLine($"|{new string(' ', i)}/");
        }
    }
}
