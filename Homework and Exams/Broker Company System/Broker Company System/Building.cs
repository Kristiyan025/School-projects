namespace BrokerCompanySystem
{
    using System;

    public abstract class Building
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmount;

        public Building(string name, string city, int stars, double rentAmount)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.RentAmount = rentAmount;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if(value == null || value == "")
                {
                    throw new ArgumentException("Building name must not be null or empty!");
                }

                this.name = value;
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

        public int Stars
        {
            get => this.stars;
            private set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("Stars cannot be less than 0 or above 5!");
                }

                this.stars = value;
            }
        }

        public double RentAmount
        {
            get => this.rentAmount;
            private set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Rent amount cannot be less or equal to 0!");
                }

                this.rentAmount = value;
            }
        }

        public bool IsAvailable { get; set; } = true;

        public override string ToString()
        {
            return $"****Building: {this.Name} <{this.Stars}>\n" +
                   $"****Location: {this.City}\n" +
                   $"****RentAmount: {this.RentAmount}\n" +
                   $"****Is Available: {this.IsAvailable}";
        }
    }
}
