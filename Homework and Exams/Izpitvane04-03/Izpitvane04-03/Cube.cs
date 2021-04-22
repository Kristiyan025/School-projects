using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvane04_03
{
    class Cube : GeometryObject, IObject3D
    {
        public Cube(double a)
        {
            this.A = a;
        }

        public double A { get; set; }

        public double FullArea()
        {
            return 4 * A * A;
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            throw new NotImplementedException();
        }

        public double Volume()
        {
            return A * A * A;
        }
    }
}
