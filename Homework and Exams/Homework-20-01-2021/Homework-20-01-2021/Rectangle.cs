using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_20_01_2021
{
    public class Rectangle
    {
        private double width, height;

        public Rectangle()
        {
            this.width = this.height = 1;
        }

        public Rectangle(double width, double height)
        {
            if(width < 0)
            {
                throw new ArgumentException("Width must be non-negative!", nameof(width));
            }

            if(height < 0)
            {
                throw new ArgumentException("Height must be non-negative!", nameof(height));
            }

            this.width = width;
            this.height = height;
        }

        public double Area()
            => this.width * this.height;
    }
}
