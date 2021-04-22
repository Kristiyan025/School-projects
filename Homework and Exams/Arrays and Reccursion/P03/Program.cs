using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    arr1[i] = num1;
                    arr2[i] = num2;
                }
                else
                {
                    arr1[i] = num2;
                    arr2[i] = num1;
                }
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
