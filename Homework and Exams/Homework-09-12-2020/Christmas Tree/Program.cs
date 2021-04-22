using System;

namespace Christmas_Tree
{
    class Program
    {
        static ConsoleColor[] consoleColors
            = (ConsoleColor[])ConsoleColor
                  .GetValues(typeof(ConsoleColor));
        static Random r = new Random();

        static void Main()
        {
            Console.CursorVisible = false;
            int n = 40;
            Console.SetWindowSize(2 * n - 1, n);
            PrintTree(n);
            while (true)
            {
                //Console.
                int y = r.Next(0, Console.WindowHeight);
                int x = r.Next(n - 1 - y, Console.WindowWidth - n + y);
                //if(y != n && x + y >= n - 1 && Console.WindowWidth - x - 1 + y >= n - 1)
                //{
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = (ConsoleColor)r.Next(1, consoleColors.Length);
                    Console.Write('*');
                //}
                
            }
        }

        static void PrintTree(int n)
        {
            //Console.SetCursorPosition(0, 0);
            for(int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for(int j = 0; j < 1 + 2 * (i - 1); j++)
                {
                    Console.ForegroundColor = (ConsoleColor)r.Next(1, consoleColors.Length);
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
