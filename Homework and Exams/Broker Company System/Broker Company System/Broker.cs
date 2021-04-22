namespace BrokerCompanySystem
{
    using System;
    using System.Collections.Generic;

    public class Broker
    {
        private string name;
        private int age;
        private string city;
        private List<Building> buildings;

        public Broker(string name, int age, string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.Bonus = 0.0;
            this.buildings = new List<Building>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Broker name must not be null or empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 16 || value > 70)
                {
                    throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
                }

                this.age = value;
            }
        }

        public string City
        {
            get => this.city;
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("City must not be null or empty!");
                }

                this.city = value;
            }
        }

        public double Bonus { get; private set; }

        public double ReceiveBonus(Building building)
        {
            double currBonus = building.RentAmount * 2 * building.Stars / 100;
            this.Bonus += currBonus;
            this.buildings.Add(building);
            return currBonus;
        }

        public override string ToString()
        {
            string s = $"****Broker: {this.Name} <{this.Age}>\n" +
                       $"****Location: {this.City}\n" +
                       $"****Bonus: {this.Bonus}\n";
            foreach(Building b in this.buildings)
            {
                s += $"****** {b.Name}\n";
            }
            return s.Trim();
        }
    }
}
