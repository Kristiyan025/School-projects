using System.Collections.Generic;
using System.Linq;
using BrokerCompanySystem;

public class CompanyController
{
    private List<Company> companies;

    public CompanyController()
    {
        this.companies = new List<Company>();
    }

    public string CreateCompany(List<string> args)
    {
        string name = args[0];
        Company company = this.companies.Find(x => x.Name == name);
        if(company == null)
        {
            this.companies.Add(new Company(name));
            return $"Company {name} was successfully registerd in the system!";
        }
        else
        {
            return $"Company {name} is already registered!";
        }
    }

    public string RegisterBuilding(List<string> args)
    {
        string type = args[0];
        string name = args[1];
        string city = args[2];
        int stars = int.Parse(args[3]);
        double rentAmount = double.Parse(args[4]);
        string companyName = args[5];
        Company company = this.companies.Find(x => x.Name == companyName);
        if(company == null)
        {
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        else
        {
            Building building = company.GetBuildingByName(name);
            if(building == null)
            {
                switch (type)
                {
                    case nameof(Hotel):
                        building = new Hotel(name, city, stars, rentAmount);
                        break;
                    case nameof(Residence):
                        building = new Residence(name, city, stars, rentAmount);
                        break;
                    case nameof(Business):
                        building = new Business(name, city, stars, rentAmount);
                        break;
                }

                company.AddBuilding(building);
                return $"Building {name} was successfully registerd in {companyName} catalog!";
            }
            else
            {
                return $"Building {name} is already registered in {companyName}!";
            }
        }
    }

    public string RegisterBroker(List<string> args)
    {
        this.companies = this.companies.OrderBy(x => x.Name).ToList();
        string name = args[0];
        int age = int.Parse(args[1]);
        string city = args[2];
        string companyName = args[3];
        Company company = this.companies.Find(x => x.Name == companyName);
        if(company == null)
        {
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        else
        {
            Broker broker = company.GetBrokerByName(name);
            if(broker == null)
            {
                company.AddBroker(new Broker(name, age, city));
                return $"Broker {name} was successfully hired in {companyName}!";
            }
            else
            {
                return $"Broker {name} is already part of {companyName}!";
            }
        }
    }

    public string RentBuilding(List<string> args)
    {
        string companyName = args[0];
        string buildingName = args[1];
        string brokerName = args[2];
        Company company = this.companies.Find(x => x.Name == companyName);
        if(company == null)
        {
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        else
        {
            Building building = company.GetBuildingByName(buildingName);
            if(building == null)
            {
                return $"Invalid Building: {buildingName}. Cannot find it in {companyName} catalog!";
            }
            else if(!building.IsAvailable)
            {
                return $"Building: {buildingName} cannot be rented!";
            }
            else
            {
                Broker broker = company.GetBrokerByName(brokerName);
                if (broker == null)
                {
                    return $"Invalid Broker: {brokerName}. Cannot find employee in {companyName}!";
                }
                else
                {
                    building.IsAvailable = false;
                    double bonus = broker.ReceiveBonus(building);
                    return $"Successfully rented {buildingName}!\n" +
                           $"Broker {brokerName} earned {bonus}!"; ;
                }
            }
        }
    }

    public string CompanyInfo(List<string> args)
    {
        string companyName = args[0];
        Company company = this.companies.Find(x => x.Name == companyName);
        if(company == null)
        {
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        else
        {
            return company.ToString();
        }
    }

    public string Shutdown()
    {
        string s = $"Companies: {this.companies.Count}\n";
        foreach(Company company in this.companies)
        {
            s += this.CompanyInfo(new List<string> { company.Name }) + "\n";
        }
        return s.TrimEnd();
    }
}
