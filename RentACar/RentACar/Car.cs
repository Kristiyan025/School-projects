using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class Car
    {
        public Car(string model, string info, Bitmap image)
        {
            this.Model = model;
            this.Info = info;
            this.Image = image;
        }

        public string Model { get; private set; }

        public string Info { get; private set; }

        public Bitmap Image { get; private set; }
    }
}
