using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Swap(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }

        static void BubbleSort1(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1]) Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }

        static void BubbleSort2(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
                if (swapped == false) break;
            }
        }

        static void BubbleSort3(int[] arr)
        {
            int last = arr.Length - 2;
            while (last > 0)
            {
                int newLast = 0;

                for (int i = 0; i <= last; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        newLast = i;
                    }
                }
                last = newLast - 1;
            }
        }

        static void SelectedSort(int[] a)
        {
            int n = a.Length, min, index;
            for (int i = 0; i <= n - 2; i++)
            {
                min = a[i]; index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        index = j;
                    }
                }
                a[index] = a[i]; a[i] = min;
            }
        }
    }
}
