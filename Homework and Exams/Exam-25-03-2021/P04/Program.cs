using System;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum(arr));
        }

        static int sum(int[] arr, int pos = 0)
        {
            if (pos == arr.Length) return 0;
            return arr[pos] + sum(arr, pos + 1);
        }
    }
}
