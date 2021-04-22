using System;
using System.Linq;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        Console.Write(arr1[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
