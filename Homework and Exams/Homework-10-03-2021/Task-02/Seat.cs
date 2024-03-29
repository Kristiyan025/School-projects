﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_02
{
    public class Seat : ICar
    {
        private string model, color;

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} {nameof(Seat)} {this.Model}\n" +
                this.Start() + '\n' + this.Stop();
        }
    }
}
