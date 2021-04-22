using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_20_01_2021
{
    public class Circle
    {
        private double r;
        
        public Circle()
        {
            this.r = 1;
        }

        public Circle(double r)
        {
            if(r < 0)
            {
                throw new ArgumentException("Radius must be non-negative!");
            }

            this.r = r;
        }

        public double Area()
            => Math.PI * this.r * this.r;
    }
}
