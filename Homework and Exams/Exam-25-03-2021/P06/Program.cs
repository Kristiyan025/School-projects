using System;

namespace P06
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

            Console.WriteLine(min(arr, 0));
        }

        static int min(int[] arr, int pos)
        {
            if (pos == arr.Length) return int.MaxValue;
            return Math.Min(arr[pos], min(arr, pos + 1));
        }
    }
}
