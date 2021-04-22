using System;
using System.Collections.Generic;
using System.Text;
using Food;

namespace Animals
{
    public class Animal
    {
        private Foods food;
        private int years;

        public Animal() : this(true) { }

        protected Animal(int years, string kind)
        {
            this.Years = years;
            this.Kind = kind;
        }

        public Animal(string poroda)
        {
            this.Kind = poroda;
        }

        private Animal(bool isHungry)
        {

        }

        public int Years 
        { 
            get
            {
                return years;
            }
            set
            {
                //Validation
                //Positive
                if(value > 100)
                {
                    throw new Exception("Wrong value");
                }
                years = value;
            }
        }

        public string Kind { get; set; }

        //fields
        //constructors
        //properties
        //methods
        public void Eat()
        {

        }
        public void Sleep()
        {

        }
        public void Run()
        {

        }
    }
}
