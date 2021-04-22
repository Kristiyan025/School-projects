using System;
using System.Threading;

namespace Christmas_Tree
{
    public class Program
    {
        const int n = 40;
        static Random r = new Random();

        public static void Main()
        {
            SetUp();
            PrintTree(n);
            Loop();
        }

        private static void SetUp()
        {
            Console.SetWindowSize(2 * n, n);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            DisableConsoleInput.Go();
            Console.CursorVisible = false;
            Console.Title = "Christmas Tree";
        }

        private static void PrintTree(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 0; j < 1 + 2 * i; j++)
                {
                    Console.ForegroundColor = (ConsoleColor)r.Next(1, 16);
                    Console.Write('*');
                }
                if(i != n - 1) Console.WriteLine();
            }
        }

        private static void Loop()
        {
            while (true)
            {
                int y = r.Next(0, n);
                int x = r.Next(n - y, Console.WindowWidth - (n - y - 1));
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = (ConsoleColor)r.Next(1, 16);
                Console.Write('*');
            }
        }
    } 
}
