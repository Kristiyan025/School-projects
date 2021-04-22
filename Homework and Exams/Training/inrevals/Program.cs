using System;

namespace inrevals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int Interval(int a, int b)
        {
            int sum = 0;
            for(int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        static double f(int m, int n)
        {
            return (double)Interval(1, 153) / Interval(m, n);
        }

        static void Square(int n)
        {
            for(int i = 0; i < 2 * n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            for(int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for(int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }

            return a;
        }

        static void g(int n, ref int chislitel, ref int znamenatel)
        {
            chislitel = 0;
            znamenatel = 1;
            int znak = 1;
            for(int i = 1; i <= n; i++)
            {
                chislitel = chislitel * i + znak * znamenatel;
                znamenatel = znamenatel * i;
                znak *= -1;
            }

            int gcd = GCD(chislitel, znamenatel);
            chislitel /= gcd;
            znamenatel /= gcd;
        }

        static bool isCool(int n)
        {
            int m = n;
            while(m > 0)
            {
                int digit = m % 10;
                if(n % digit != 0)
                {
                    return false;
                }

                m /= 10;
            }

            return true;
        }
    }
}
