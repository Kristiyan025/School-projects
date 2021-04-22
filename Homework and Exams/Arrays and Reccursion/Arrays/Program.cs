using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //#0                     #size - 1
            //0 1 2 3 4 5 6 7 8 9 10 11
            //2 3 5 6 5 4 5 6 7 4 3 2
            //size = 12
            int[] arr = new int[] { 2, 3, 5, 6, 5, 4, 5, 6, 7, 4, 3, 2 };
            arr[0] = 27;

            int size = arr.Length;
            for(int i = 0; i < arr.Length; i++)
            {
                //arr[i]
            }
        }
    }
}
