using System;

namespace P07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //1 2 3 4 5 6 7 8  => for [5;8] size = 8 - 5 + 1 = 4
            //0.....n - 1 -> size = n
            //1.....n -> size = n - 1 + 1 = n
            //l.....r => size = r - l + 1
            int maxLen = 0;
            int maxEl = -1;

            /*
            for(int l = 0; l < n; l++)
            {
                for(int r = l; r < n; r++)
                {
                    //subarray [l;r]
                    int el = arr[l];
                    bool isAllEqulal = true;
                    for(int i = l + 1; i <= r; i++)
                    {
                        if(arr[i] != el)
                        {
                            isAllEqulal = false;
                            break;
                        }
                    }

                    if(isAllEqulal)
                    {
                        if(r - l + 1 > maxLen)
                        {
                            maxLen = r - l + 1;
                            maxEl = arr[l];
                        }
                    }
                }
            }
            */
            for(int l = 0; l < n; l++)
            {
                int sz = 1;
                for (; l + sz < n; sz++)
                {
                    if(arr[l + sz - 1] != arr[l])
                    {
                        break;
                    }
                }

                if (sz > maxLen)
                {
                    maxLen = sz;
                    maxEl = arr[l];
                }
            }

            Console.WriteLine($"maxLen = {maxLen}, maxEl = {maxEl}");
            /*
            for(int i = 0; i < maxLen; i++)
            {
                Console.Write(maxEl + " ");
            }
            Console.WriteLine();
            */
        }
    }
}
