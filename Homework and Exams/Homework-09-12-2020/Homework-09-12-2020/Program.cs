using System;

namespace Homework_09_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Digits();
        }

        static int FindDigit(int n, int k)
        {
            int digit = 0;
            for(int i = 0; i < k; i++)
            {
                digit = n % 10;
                n /= 10;
            }

            return digit;
        }

        static void Digits()
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine(FindDigit(p, k));
            Console.WriteLine(FindDigit(q, l));
            Console.WriteLine(FindDigit(r, m));
        }
    }
}
