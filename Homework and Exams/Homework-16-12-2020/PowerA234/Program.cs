using System;

namespace PowerA234
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b, c, d;
            PowerA234(a, out b, out c, out d);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        private static void PowerA234(int A, out int B, out int C, out int D)
        {
            B = A * A;
            C = B * A;
            D = B * B;
        }
    }
}
