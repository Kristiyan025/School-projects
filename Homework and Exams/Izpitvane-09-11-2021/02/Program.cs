using System;

namespace _02
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

            Console.WriteLine(SumEvenPositives(arr, 0));
        }

        static int SumEvenPositives(int[] arr, int pos)
        {
            if (pos == arr.Length) return 0;
            if (arr[pos] > 0 && arr[pos] % 2 == 1) return arr[pos] + SumEvenPositives(arr, pos + 1);
            return SumEvenPositives(arr, pos + 1);
        }
    }
}
