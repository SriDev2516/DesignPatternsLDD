using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IVehicleFactory
    {
        IVehicle GetVehicle(string type);
    }
}
