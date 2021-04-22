namespace BrokerCompanySystem
{
    using System;

    public class Hotel : Building
    {
        public Hotel(string name, string city, int stars, double rentAmount)
            : base(name, city, stars, rentAmount)
        {
            if (!name.EndsWith(nameof(Hotel)))
            {
                throw new ArgumentException("Name of hotel buildings should end on Hotel!");
            }
        }
    }
}
