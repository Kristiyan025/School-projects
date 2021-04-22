using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int radius = int.Parse(Console.ReadLine());
                IDrawable circle = new Circle(radius);
                circle.Draw();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                IDrawable rect = new Rectangle(width, height);
                rect.Draw();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
