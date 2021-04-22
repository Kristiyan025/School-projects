using System;

namespace P05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            if(Contains(arr, p))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool Contains(int[] arr, int p, int pos = 0)
        {
            if (pos == arr.Length) return false;
            if (arr[pos] == p) return true;
            return Contains(arr, p, pos + 1);
        }
    }
}
