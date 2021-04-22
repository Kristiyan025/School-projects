using System;
using System.Collections.Generic;
using System.Linq;
using BrokerCompanySystem;

class StartUp
{
    static void Main(string[] args)
    {
        //Company company = new Company("fdf");
        Engine engine = new Engine();
        engine.Work();
    }
}