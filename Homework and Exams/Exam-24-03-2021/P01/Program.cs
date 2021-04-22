using System;
using System.Linq;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == 0 && arr[i - 1] == 0)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No");
        }
        /*
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            if(IsDecreasing(arr, 1))
            {
                Console.WriteLine("The sequence is decreasing!");
            }
            else
            {
                Console.WriteLine("The sequence is not decreasing!");
            }
        }

        static bool IsDecreasing(int[] arr, int pos)
        {
            if (pos == arr.Length) return true;
            return arr[pos] < arr[pos - 1] && IsDecreasing(arr, pos + 1);
        }*/
    }
}
