using System;

namespace P06
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
            /*
            for(int i = 0; i < n; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for(int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for(int j = i + 1; j < n; i++)
                {
                    rightSum += arr[j];
                }

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                }
            }
            */
            int[] leftSum = new int[n];
            int[] rightSum = new int[n];
            leftSum[0] = rightSum[n - 1] = 0;
            for (int i = 1; i < n; i++)
            {
                leftSum[i] = leftSum[i - 1] + arr[i];
                rightSum[n - i - 1] = rightSum[i + 1] + arr[i];
            }

            // f(i = 1) = n - 2 
            // f(i = 2) = n - 3 
            // f(i = 3) = n - 4 
            // f(i = 4) = n - 5
            // f(i = k) = n - 1 -k
            for (int i = 0; i < n; i++)
            {
                if(leftSum[i - 1] == rightSum[i + 1])
                    Console.WriteLine(arr[i]);
            }
        }
    }
}
