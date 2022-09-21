using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class LuxuryFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(string type)
        {
            switch (type)
            {
                case "BMW":
                    return new BMW();
                case "AUDI":
                    return new Audi();
                default:
                    return null;
            }
        }
    }
}
