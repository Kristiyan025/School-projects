using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    class Time
    {
        private int hour, minute, second;

        public Time()
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
        }

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public string Format()
        {
            return $"{this.hour}:{this.minute}:{this.second}";
        }
    }
}
