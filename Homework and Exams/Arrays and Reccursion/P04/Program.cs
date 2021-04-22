using System;

namespace P04
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

            int rotations = int.Parse(Console.ReadLine());
            /*
            for(int i = 0; i < rotations; i++)
            {
                int first = arr[0];
                for(int j = 0;  j <= arr.Length - 2; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = first;
            }
            */
            int[] prefix = new int[rotations];
            for(int j = 0; j < rotations; j++)
            {
                prefix[j] = arr[j];
            }
            for (int j = 0; j <= arr.Length - rotations - 1; j++)
            {
                arr[j] = arr[j + rotations];
            }
            for (int j = arr.Length - rotations; j < arr.Length; j++)
            {
                arr[j] = prefix[j];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
