using System;

namespace Exam_27_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle r1 = new Rectangle();
                Console.WriteLine(r1.Format());
                Console.WriteLine(r1.Area());

                Rectangle r2 = new Rectangle(3, 5);
                Console.WriteLine(r2.Format());
                Console.WriteLine(r2.Area());

                Rectangle r3 = new Rectangle(-3, 5);
                Console.WriteLine(r2.Format());
                Console.WriteLine(r2.Area());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
