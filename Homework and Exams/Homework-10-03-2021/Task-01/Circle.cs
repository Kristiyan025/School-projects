using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01
{
    public class Circle : IDrawable
    {
        private double rInSq, rOutSq; 
        private int r;

        public Circle(int r)
        {
            this.R = r;
            this.rInSq = this.R - 0.4;
            this.rOutSq = this.R + 0.4;
            this.rInSq *= this.rInSq;
            this.rOutSq *= this.rOutSq;
        }

        public int R 
        {
            get => this.r; 
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Radius must be positive!");

                this.r = value;
            }
        }

        public void Draw()
        {
            for(int i = -this.R; i <= this.R; i++)
            {
                for(double j = -this.R; j <= this.R; j+= 0.5)
                {
                    double distSq = i * i + j * j;
                    Console.Write((distSq >= rInSq && distSq <= rOutSq) ? '*' : ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
