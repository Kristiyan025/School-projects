using System;
using System.Collections.Generic;
using System.Linq;
using BrokerCompanySystem;

public class Engine
{
    public Engine() {}
    
    public void Work()
    {
        CompanyController cc = new CompanyController();

        while (true)
        {
            try
            {
                string command = Console.ReadLine();
                if(command == "Shutdown")
                {
                    Console.WriteLine(cc.Shutdown()); 
                    return;
                }
    
                string[] commandParts = command
                    .Split('*')
                    .ToArray();
    
                //Checking for the right command

                switch (commandParts[0])
                {
                    case "CreateCompany":
                        Console.WriteLine(cc.CreateCompany(new List<string> { commandParts[1] }));
                        break;
                    case "RegisterBuilding":
                        Console.WriteLine(cc.RegisterBuilding(new List<string> { commandParts[1], 
                                                                                 commandParts[2], 
                                                                                 commandParts[3], 
                                                                                 commandParts[4], 
                                                                                 commandParts[5],
                                                                                 commandParts[6] }));
                        break;
                    case "RegisterBroker":
                        Console.WriteLine(cc.RegisterBroker(new List<string> { commandParts[1],
                                                                               commandParts[2],
                                                                               commandParts[3],
                                                                               commandParts[4] }));
                        break;
                    case "RentBuilding":
                        Console.WriteLine(cc.RentBuilding(new List<string> { commandParts[1],
                                                                             commandParts[2],
                                                                             commandParts[3] }));
                        break;
                    case "CompanyInfo":
                        Console.WriteLine(cc.CompanyInfo(new List<string> { commandParts[1] }));
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}