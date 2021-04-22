using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01
{
    public class Rectangle : IDrawable
    {
        private int w, h;

        public Rectangle(int w, int h)
        {
            this.W = w;
            this.H = h;
        }

        public int W
        {
            get => this.w;
            set
            {
                if(value < 1)
                    throw new ArgumentOutOfRangeException("Width must be positive!");

                this.w = value;
            }
        }

        public int H
        {
            get => this.h;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Height must be positive!");

                this.h = value;
            }
        }

        public void Draw()
        {
            string endRow = new string('*', W);
            Console.WriteLine(endRow);
            string middleRow = '*' + (this.W > 1 ? new string(' ', this.W - 2) + '*' : "");
            for (int i = 0; i < this.H - 2; i++)
            {
                Console.WriteLine(middleRow);
            }

            if(this.H > 1) Console.WriteLine(endRow);
        }
    }
}
