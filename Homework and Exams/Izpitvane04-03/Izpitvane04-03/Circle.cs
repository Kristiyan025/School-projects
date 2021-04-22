using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvane04_03
{
    public class Circle : GeometryObject, IObject2D
    {
        public Circle()
        {

        }

        private double R { get; set; }

        public override void Read()
        {
            Console.Write("Enter the circle's radius: ");
            this.R = double.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine("Circle:");
            Console.WriteLine($"Radius: {this.R:F2}");
            Console.WriteLine($"Perimeter: {Perimeter():F2}");
            Console.WriteLine($"Area: {Area():F2}");
        }

        public double Area()
        {
            return this.R * this.R * Math.PI;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }
}
