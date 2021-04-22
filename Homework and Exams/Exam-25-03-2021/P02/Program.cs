using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int m = int.Parse(Console.ReadLine());
            int[] arr2 = new int[m];
            for (int i = 0; i < m; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for(int i = 0; i  <n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (arr1[i] == arr2[j]) count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
