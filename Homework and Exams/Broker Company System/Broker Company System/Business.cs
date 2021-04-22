namespace BrokerCompanySystem
{
    using System;

    public class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount)
            : base(name, city, stars, rentAmount)
        {
            if (!name.EndsWith(nameof(Business)))
            {
                throw new ArgumentException("Name of business buildings should end on Business!");
            }
        }
    }
}
