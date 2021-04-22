using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFactorization(n);
        }

        static void PrintFactorization(int n, int fact = 2)
        {
            if(n == 1)
            {
                Console.WriteLine();
                return;
            }

            if (n % fact == 0)
            {
                Console.Write(fact + " ");
                PrintFactorization(n / fact, fact);
            }
            else PrintFactorization(n, fact + 1);
        }
    }
}
