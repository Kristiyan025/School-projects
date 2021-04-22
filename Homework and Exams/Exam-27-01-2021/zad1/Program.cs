using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            Console.WriteLine(t1.Format());

            Time t2 = new Time(2, 3, 4);
            Console.WriteLine(t2.Format());
        }
    }
}
