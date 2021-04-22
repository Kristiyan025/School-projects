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
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                if(arr[i] > 0)
                {
                    sum += arr[i];
                }
                if(arr[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(count);
        }
    }
}
