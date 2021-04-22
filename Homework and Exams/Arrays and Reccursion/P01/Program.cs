using System;

namespace P01
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

            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
