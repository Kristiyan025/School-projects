using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvane04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Read();
            c.Print();

            Prism p = new Prism();
            p.Read();
            p.Print();

            double a = double.Parse(Console.ReadLine());
            Cube cube = new Cube(a);
            Console.WriteLine(cube.FullArea());
            Console.WriteLine(cube.Volume());
        }
    }
}
