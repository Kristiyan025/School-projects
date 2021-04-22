using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintBinary(n);
            Console.WriteLine();
        }

        static void PrintBinary(int n)
        {
            if (n < 2)
            {
                Console.Write(n);
                return;
            }

            PrintBinary(n / 2);
            Console.Write(n % 2);
        }
    }
}
