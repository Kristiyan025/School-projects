using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_20_01_2021
{
    public class Time
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
            if(!IsValidTime(hour, minute, second))
            {
                throw new ArgumentOutOfRangeException("The hour must be between 0 and 24, the minute and the second - between 0 and 60!");
            }

            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public override string ToString()
            =>$"{this.hour:D2}:{this.minute:D2}:{this.second:D2}";

        public string Format()
            => this.ToString();

        private bool IsValidTime(int hour, int minute, int second)
            => hour >= 0 && hour < 24 &&
               minute >= 0 && minute < 60 &&
               second >= 0 && second < 60;
    }
}
