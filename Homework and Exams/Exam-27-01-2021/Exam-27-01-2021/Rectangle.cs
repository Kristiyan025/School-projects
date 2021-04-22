using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_27_01_2021
{
    class Rectangle
    {
        private double width, height;

        public Rectangle()
        {
            this.width = 0;
            this.height = 0;
        }

        public Rectangle(double width, double height)
        {
            if(width < 0 || height < 0)
            {
                throw new Exception("Lengths must be non-negative!");
            }

            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return this.width * this.height;
        }

        public string Format()
        {
            return $"Rectangle: {this.width} x {this.height}";
        }
    }
}
