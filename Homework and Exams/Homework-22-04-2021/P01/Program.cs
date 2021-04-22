using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int mini;
            for (int i = 0; i < n; i++)
            {
                mini = int.MaxValue;
                for(int j = 0; j < m; j++)
                {
                    mini = arr[i, j] < mini ? arr[i, j] : mini;
                }

                Console.WriteLine(mini);
            }
        }
    }
}
