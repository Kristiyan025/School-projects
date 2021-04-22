using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine()); 
            double la = 0, lb = 0, lc = 0;
            zadacha1(a, b, c, ref la, ref lb, ref lc);
            Console.WriteLine($"{la} {lb} {lc}");
        }

        static void zadacha1(double a, double b, double c, ref double la, ref double lb, ref double lc)
        {
            if(!(a + b > c && b + c > a && c + a > b))
            {
                Console.WriteLine("no such triangle");
                return;
            }

            //ima triugulnik
            la = Math.Sqrt(b * c - b * c * a * a / ((b + c) * (b + c)));
            lb = Math.Sqrt(a * c - a * c * b * b / ((a + c) * (a + c)));
            la = Math.Sqrt(b * a - b * a * c * c / ((b + a) * (b + a)));
        }
    }

        //purvata na vtorata snimka
        private static int SumInterval(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum;
        }

        private static void F(int m, int n, ref double result)
        {
            result = (double)SumInterval(1, 153) / SumInterval(m, n);
        }

        static double linear(double a, double b)
        {
            Console.WriteLine($"{a} * x + {b} = 0:");
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("vsqko x");
                }
                else
                {
                    Console.WriteLine("nikoe x");
                }
            }
            else
            {
                double root = -b / a;
                Console.WriteLine("x = {root}");
                return root;
            }

            return 0;
        }

        static void zad2(double a1, double b1, double a2, double b2, ref double result)
        {
            result = linear(a1, b1) + linear(a2, b2);
        }

        static int Sign(double num)
        {
            if (num > 0) return 1;
            else if (num == 0) return 0;
            else return -1;
        }

        static void zad1(double x, double y, ref double result)
        {
            result = (Sign(x) + Sign(y)) * Sign(x * y);
        }

}
