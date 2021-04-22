using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int nod = NOD(arr[0], arr[2]);
            for(int i = 2; i < n; i++)
            {
                nod = NOD(nod, arr[i]);
            }

            Console.WriteLine(nod);
        }

        static int NOD(int a, int b)
        {
            while(b != 0)
            {
                int newA = a % b;
                a = b;
                b = newA;
            }

            return a;
        }
    }
}
