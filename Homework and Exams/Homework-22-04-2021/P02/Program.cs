using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int count;
            for (int j = 0; j < m; j++)
            {
                count = 0;
                for (int i = 0; i < n; i++)
                {
                    if ((arr[i, j] & 1) == 0) count++;
                }

                Console.WriteLine(count);
            }
        }
    }
}
