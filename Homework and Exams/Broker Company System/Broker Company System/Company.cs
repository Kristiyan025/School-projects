namespace BrokerCompanySystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Company
    {
        private string name;
        private List<Building> buildings;
        private List<Broker> brokers;

        public Company(string name)
        {
            this.Name = name;
            this.buildings = new List<Building>();
            this.brokers = new List<Broker>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Company name must not be null or empty!");
                }

                this.name = value;
            }
        }

        public void AddBroker(Broker broker)
        {
            Broker br = this.brokers.Find(b => b.Name == broker.Name);
            if(br == null)
            {
                this.brokers.Add(broker);
            }
        }

        public void AddBuilding(Building building)
        {
            Building bd = this.buildings.Find(b => b.Name == building.Name);
            if (bd == null)
            {
                this.buildings.Add(building);
            }
        }

        public Broker GetBrokerByName(string name)
        {
            Broker br = this.brokers.Find(b => b.Name == name);
            return br;
        }

        public Building GetBuildingByName(string name)
        {
            Building bd = this.buildings.Find(b => b.Name == name);
            return bd;
        }

        public override string ToString()
        {
            string s = $"Company: {this.Name}\n" +
                       $"##Brokers: {this.brokers.Count}\n";
            foreach(Broker b in this.brokers)
            {
                s += $"{b.ToString()}\n";
            }
            
            s += $"##Buildings: {this.buildings.Count}\n";
            foreach(Building b in this.buildings)
            {
                s += $"{b.ToString()}\n";
            }
            return s.Trim();
        }
    }
}
