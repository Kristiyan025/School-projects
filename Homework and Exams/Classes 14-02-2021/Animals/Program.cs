using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            //a.Years = 101;
            Tiger t = new Tiger(5);
            t.Eat();
            t.Years = 4;
        }
    }
}
