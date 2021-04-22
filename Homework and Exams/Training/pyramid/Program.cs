using System;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintPyramid(n);
        }

        static void PrintPyramid(int n)
        {
            int spaces = 2 * (n - 1);
            for(int i = 1; i <= n; i++)
            {
                for(int j = 0; j < spaces; j++)
                {
                    Console.Write(' ');
                }
                spaces -= 2;
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
