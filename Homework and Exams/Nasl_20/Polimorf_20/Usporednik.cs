using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorf_20
{
    public class Usporednik
    {
        public double LiceU(double a, double ha)
        {
            return a * ha;
        }

        public double LiceU(double a, double b, double alpha)
        {
            return a * b * Math.Sin(alpha);
        }

        public double LiceU(double d1, double d2, decimal phi)
        {
            return d1 * d2 * Math.Sin((double)phi);
        }
    }
}
