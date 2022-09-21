using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class OrdinaryVehicle : IVehicleFactory
    {
        public IVehicle GetVehicle(string type)
        {
            return new Swift();
        }
    }
}
