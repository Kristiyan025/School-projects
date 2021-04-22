using System;
using System.Collections.Generic;
using System.Text;

namespace Nasl_20
{
    public class Usporednik
    {
        public Usporednik(double a, double b, double h, bool zaKoq)
        {
            this.A = a;
            this.B = b;
            this.H = h;
            this.ZaKoqStranaEVisochinata = zaKoq;
        }

        public double A { get; protected set; }

        public double B { get; protected set; }

        public double H { get; protected set; }

        public bool ZaKoqStranaEVisochinata { get; set; } //true - za A, false - za B

        public virtual double Perimetyr()
        {
            return 2 * (this.A + this.B);
        }

        public virtual double Plosht()
        {
            if(this.ZaKoqStranaEVisochinata)
            {
                return this.A * this.H;
            }
            else
            {
                return this.B * this.H;
            }
        }
    }
}
