using System;

namespace nok_and_nod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int lcm = LCM(a, b);
            for (int i = 2; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                lcm = LCM(lcm, num);
            }
            Console.WriteLine(lcm);
        }

        static int GCD(int a, int b)
        {
            while(b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }

            return a;
        }

        static int LCM(int a, int b)
        {
            return a / GCD(a, b) * b;
        }
    }
}
