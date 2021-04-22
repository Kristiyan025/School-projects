using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Car
    {
        public int tires;
        public int windows;

        public Car()
        {
            tires = 4;
            windows = 8;
        }

        public Car(int tires, int w)
        {
            this.tires = tires;
            windows = w;
        }
    }
}
