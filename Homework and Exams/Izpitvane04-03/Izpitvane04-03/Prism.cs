using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvane04_03
{
    public class Prism : GeometryObject, IObject3D
    {
        public Prism()
        {

        }

        private int Vertices { get; set; }

        private double Base { get; set; }

        private double Height { get; set; }

        public override void Read()
        {
            Console.Write("Enter the prism's vertices' count: ");
            this.Vertices = int.Parse(Console.ReadLine());

            Console.Write("Enter the prism's base: ");
            this.Base = double.Parse(Console.ReadLine());

            Console.Write("Enter the prism's height: ");
            this.Height = double.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine("Prism:");
            Console.WriteLine($"Vertices' count: {this.Vertices}");
            Console.WriteLine($"Base: {this.Base:F2}");
            Console.WriteLine($"Height: {this.Height:F2}");
            Console.WriteLine($"Full Area: {FullArea():F2}");
            Console.WriteLine($"Volume: {Volume():F2}");
        }

        public double FullArea()
        {
            double baseArea = 0;
            if(this.Vertices == 3)
            {
                baseArea = Math.Sqrt(3) / 4.0 * this.Base * this.Base;
            }
            else if(this.Vertices == 4)
            {
                baseArea = this.Base * this.Base;
            }

            double surroundingArea = this.Vertices * this.Base * this.Height;
            return 2 * baseArea + surroundingArea;
        }

        public double Volume()
        {
            double baseArea = 0;
            if (this.Vertices == 3)
            {
                baseArea = Math.Sqrt(3) / 4.0 * this.Base * this.Base;
            }
            else if (this.Vertices == 4)
            {
                baseArea = this.Base * this.Base;
            }
            return baseArea * this.Height;
        }
    }
}
