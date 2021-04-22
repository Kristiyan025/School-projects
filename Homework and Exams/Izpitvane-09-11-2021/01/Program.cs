using System;

namespace _01
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

            Console.WriteLine(CheckForAdjacentZeros(arr, 1));
        }

        static bool CheckForAdjacentZeros(int[] arr, int pos)
        {
            if (pos == arr.Length) return false;
            if (arr[pos] == 0 && arr[pos - 1] == 0) return true;
            return CheckForAdjacentZeros(arr, pos + 1);
        }
    }
}
