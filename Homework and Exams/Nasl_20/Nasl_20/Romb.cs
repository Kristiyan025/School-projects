using System;
using System.Collections.Generic;
using System.Text;

namespace Nasl_20
{
    public class Romb : Usporednik
    {
        public Romb(double a, double h) 
            :base(a, a, h, true) { }

        public override double Perimetyr()
        {
            return 4 * this.A;
        }

        public override double Plosht()
        {
            return this.A * this.H;
        }
    }
}
