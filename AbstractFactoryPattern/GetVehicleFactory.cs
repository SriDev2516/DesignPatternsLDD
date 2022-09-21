using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class GetVehicleFactory
    {
        public IVehicleFactory GetVehicleFromFactory(string type)
        {
            switch (type)
            {
                case "Luxury":
                    return new LuxuryFactory();
                case "Ordinary":
                    return new OrdinaryVehicle();
                default:
                    return null;
            }
        }
    }
}
