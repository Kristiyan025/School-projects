using System;

namespace P05
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

            for(int i = 0; i < n; i++)
            {
                bool isBigger = true;
                for(int j = i + 1; j < n; j++)
                {
                    if(!(arr[i] > arr[j]))
                    {
                        isBigger = false;
                        break;
                    }
                }

                if(isBigger)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
